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
    public partial class Modelchose : Form
    {
        private List<Question> m_allCla;
        private List<Classification> m_class;
        private IDataPumpSearchQueManager SearchQueManager;

        private TreeNode findPaNode(String c_pa)//没查询到就返回-1
        {
            for (int i = 0; i < this.m_tvSubStru.Nodes.Count; i++)
            {
                if (String.Equals(this.m_tvSubStru.Nodes[i].Text,c_pa))
                {
                    return this.m_tvSubStru.Nodes[i];
                }
            }
            return null;
        }
        public Modelchose()
        {
            InitializeComponent();
            
            //录入学科
            TreeNode t1,t2;
            SearchQueManager = new DataPumpSearchQueManager();
            m_class = SearchQueManager.SetOfClassification();
            for (int i = 0; i < m_class.Count(); i++)
            {
                //TreeNode []tmp = this.m_tvSubStru.Nodes.Find(this.m_class[i].Cla[0], false);
                TreeNode tmp = findPaNode(this.m_class[i].Cla[0]);
                if (tmp == null)
                {
                    t1 = new TreeNode(m_class[i].Cla[0]);
                    t1.Tag = m_class[i].cId;

                    t2 = new TreeNode(m_class[i].Cla[1]);
                    t2.Tag = m_class[i].cId;
                    t1.Nodes.Add(t2);
                    this.m_tvSubStru.Nodes.Add(t1);
                }
                else
                {
                    t1 = new TreeNode(m_class[i].Cla[1]);
                    t1.Tag = m_class[i].cId;
                    tmp.Nodes.Add(t1);
                }                
            }
        }

        private void m_btnStart_Click(object sender, EventArgs e)
        {
            int flag = 1;//默认考试模式,1:考试 2：刷题
            //判断刷题模式是否已经选择
            if (this.m_rbExam.Checked == true)
                flag = 1;
            else if (this.m_rbPractice.Checked == true)
                flag = 2;
            else
            {
                MessageBox.Show("不提供该训练方式！");
                return;
            }            
           
            //跳转刷题界面
            testManager tmpTest = new testManager();
            int C_id = Convert.ToInt32(this.m_tvSubStru.SelectedNode.Tag);
            char pattern = this.m_rbExam.Checked == true ? 'e' : 'p';//选择刷题类型 e:exam p:practice
            bool[] queSub = new bool[5];//choice,  gapFilling,  TOF,  calc,  shortAns

            if (this.m_cbChoice.Focus())    queSub[0] = true;
            else
                queSub[0] = false;

            if (this.m_cbGapFilling.Focus())    queSub[1] = true;
            else
                queSub[0] = false;

            if (this.m_cbTOF.Focus())   queSub[2] = true;
            else
                queSub[0] = false;

            if (this.m_cbCalc.Focus())  queSub[3] = true;
            else
                queSub[0] = false;

            if (this.m_cbShortAns.Focus())  queSub[4] = true;
            else
                queSub[0] = false;

            tmpTest.formTestManager(pattern,C_id, queSub[0], queSub[1], queSub[2], queSub[3], queSub[4]);
        }

        private void m_tvQueSturct_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void m_tvSubStru_AfterSelect(object sender, TreeViewEventArgs e)
        {/*
            int flag = 1;//默认考试模式,1:考试 2：刷题
            //判断刷题模式是否已经选择
            if (this.m_rbExam.Checked == true)
                flag = 1;
            else if (this.m_rbPractice.Checked == true)
                flag = 2;
            else
            {
                MessageBox.Show("不提供该训练方式！");
                return;
            }

            //跳转刷题界面
            testManager tmpTest = new testManager();
            int C_id = Convert.ToInt32(this.m_tvSubStru.SelectedNode.Tag);//根据点击节点获得当前类型
            char pattern = this.m_rbExam.Checked == true ? 'e' : 'p';//选择刷题类型 e:exam p:practice
            bool[] queSub = new bool[5];//choice,  gapFilling,  TOF,  calc,  shortAns

            if (this.m_cbChoice.Focus()) queSub[0] = true;
            else
                queSub[0] = false;

            if (this.m_cbGapFilling.Focus()) queSub[1] = true;
            else
                queSub[0] = false;

            if (this.m_cbTOF.Focus()) queSub[2] = true;
            else
                queSub[0] = false;

            if (this.m_cbCalc.Focus()) queSub[3] = true;
            else
                queSub[0] = false;

            if (this.m_cbShortAns.Focus()) queSub[4] = true;
            else
                queSub[0] = false;

            tmpTest.formTestManager(pattern, C_id, queSub[0], queSub[1], queSub[2], queSub[3], queSub[4]);
       */ }
   

     private void Modelchose_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
         } 
    }
}
