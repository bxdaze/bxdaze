using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LWHY;

namespace LWHY_test
{
    public partial class Exam : Form
    {
        private int count;
        private int score = 0;
        private Question user_q;
        private IDataPumpSearchQueManager m_question = new DataPumpSearchQueManager();
        private List<Question> ques;
        public Exam()
        {
            InitializeComponent();
            this.timer1.Stop();
            count = 7200;
            this.timer1.Enabled = false;
            this.timer1.Interval = 1000;
        }

        public void init(List<Question> tmp)
        {
            this.ques = tmp;
            int n = this.ques.Count();//a:选择题，b：判断题，c：计算，d简答 e填空。
            this.treeView1.Nodes.Add("选择题");
            this.treeView1.Nodes.Add("判断题");
            this.treeView1.Nodes.Add("计算题");
            this.treeView1.Nodes.Add("简答题");
            this.treeView1.Nodes.Add("填空题");
            for (int i = 0; i < 5; i++)
                this.treeView1.Nodes[i].Tag = -1;
            TreeNode tn;
            for (int i = 0; i < n; i++)
            {
                tn = new TreeNode(this.ques[i].title);
                tn.Tag = this.ques[i].questionId;
                switch (this.ques[i].type)
                {
                    case 'a':
                        this.treeView1.Nodes[0].Nodes.Add(tn);
                        break;
                    case 'b':
                        this.treeView1.Nodes[1].Nodes.Add(tn);
                        break;
                    case 'c':
                        this.treeView1.Nodes[2].Nodes.Add(tn);
                        break;
                    case 'd':
                        this.treeView1.Nodes[3].Nodes.Add(tn);
                        break;
                    case 'e':
                        this.treeView1.Nodes[4].Nodes.Add(tn);
                        break;
                }
            }
            user_q = this.ques[0];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_btnTimeStart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.m_tbSec.Text = "00";
            this.m_tbMin.Text = "00";
            this.m_tbHour.Text = "2";
            count = 7200;
            this.timer1.Start();
            this.m_btnTimeStart.Enabled = false;
            
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            count -= 1;
            this.m_tbSec.Text = (count % 60).ToString();
            this.m_tbMin.Text = ((count / 60) % 60).ToString();
            this.m_tbHour.Text = (count / 3600).ToString();
            if (count == 0)
            {
                count = 7200;
                this.m_btnTimeStart.Enabled = true;
                this.timer1.Stop();
                this.timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 7200;
            this.m_btnTimeStart.Enabled = true;
            this.timer1.Stop();
            this.timer1.Enabled = false;
            /* 和数据库交互存入成绩*/
            MessageBox.Show("本次考试成绩(只计算选择题、判断题、填空题):" + score.ToString());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Question que;
            if (this.m_tbAns.Text == String.Empty)//当前用户没有输入答案
            {
                que = m_question.FindOneQuestion(Convert.ToInt32(this.treeView1.SelectedNode.Tag));
                user_q = que;
                this.m_lbTitle.Text = que.title;
                this.m_lbBody.Text = que.body;
                return;
            }
            //获取题目答案
            int qid = Convert.ToInt32(treeView1.SelectedNode.Tag.ToString());//当前点击的树状图问题节点qid 
            if (qid < 0)//检测用户是否点击的题目
                return;
            //Question corrAns = m_question.FindOneQuestion(qid);
            Question corrAns = user_q;
            if (String.Equals(this.m_tbAns.Text, corrAns.answer))
                score += 1;
            //更新题目显示
            if (Convert.ToInt32(this.treeView1.SelectedNode.Tag) <= -1)
                return;
            que = m_question.FindOneQuestion(Convert.ToInt32(this.treeView1.SelectedNode.Tag));
            this.m_lbTitle.Text = que.title;
            this.m_lbBody.Text = que.body;
            user_q = que;
        }
       /* private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //显示选中题目
            int qid = Convert.ToInt32(this.treeView1.SelectedNode.Tag.ToString());
            if (qid < 0)//检测用户是否点击的题目
                return;
            Question que = m_question.FindOneQuestion(qid);
            user_q = que;
            this.m_lbTitle.Text = que.title;
            this.m_lbBody.Text = que.body;
            this.m_tbAns.Text = String.Empty;
        }*/
    }
}
