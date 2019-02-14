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
    public partial class Practice : Form
    {
        private IDataPumpSearchQueManager m_ques = new DataPumpSearchQueManager();
        private List<Question> ques;
        public Practice()
        {
            InitializeComponent();
        }
        public void init(List<Question> tmps)
        {
            this.ques = tmps;
            int n = this.ques.Count();//a:选择题，b：判断题，c：计算，d简答 e填空。
            this.m_tvSubStru.Nodes.Add("选择题");
            this.m_tvSubStru.Nodes.Add("判断题");
            this.m_tvSubStru.Nodes.Add("计算题");
            this.m_tvSubStru.Nodes.Add("简答题");
            this.m_tvSubStru.Nodes.Add("填空题");
            for (int i = 0; i < 5; i++)
                this.m_tvSubStru.Nodes[i].Tag = -1;
            TreeNode tmp;
            for (int i = 0; i < n; i++)
            {
                tmp = new TreeNode(this.ques[i].title);
                tmp.Tag = this.ques[i].questionId;
                switch (this.ques[i].type)
                {
                    case 'a':
                        this.m_tvSubStru.Nodes[0].Nodes.Add(tmp);
                        break;
                    case 'b':
                        this.m_tvSubStru.Nodes[1].Nodes.Add(tmp);
                        break;
                    case 'c':
                        this.m_tvSubStru.Nodes[2].Nodes.Add(tmp);
                        break;
                    case 'd':
                        this.m_tvSubStru.Nodes[3].Nodes.Add(tmp);
                        break;
                    case 'e':
                        this.m_tvSubStru.Nodes[4].Nodes.Add(tmp);
                        break;
                }
            }
        }
        private void m_btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.m_tbAns.Text == String.Empty)//未输入答案
                return;
            if (Convert.ToInt32(this.m_tvSubStru.SelectedNode.Tag) < 0)//没选中题目
                return;

            Question que = m_ques.FindOneQuestion(Convert.ToInt32(this.m_tvSubStru.SelectedNode.Tag.ToString()));
            if (que == null)
                return;
            if (String.Equals(m_tbAns.Text, que.answer))
            {
                /*和数据库交互，存储当前题目正确回答*/
                MessageBox.Show("正确回答！");
            }
            else
            {   /*和数据库交互，存储当前题目已经做过*/
                MessageBox.Show("Wrong ans!");
            }
        }

        private void m_tvSubStru_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Convert.ToInt32(this.m_tvSubStru.SelectedNode.Tag) <= -1)
                return;
            Question que = m_ques.FindOneQuestion(Convert.ToInt32(this.m_tvSubStru.SelectedNode.Tag));
            this.m_lbTitle.Text = que.title;
            this.m_lbBody.Text = que.body;
        }
    }
}
