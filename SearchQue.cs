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


namespace LWHY_Search
{
    public partial class SearchQue : Form
    {
        public SearchQue()
        {
            InitializeComponent();
            
           
        }
        public questionBank questionBankForm;
        public List<Question> queAns;


        private void m_btnSearch_Click(object sender, EventArgs e)
        {
            String str = m_tbQue.Text;
            if (str == String.Empty)
            {
                MessageBox.Show("请输入内容！");
                return;
            }

            int i;

            for (i = 0; i < this.m_gbSearch.Controls.Count; i++)//遍历所有radioButton
            {
                RadioButton tmp = this.m_gbSearch.Controls[i] as RadioButton;
                if (tmp.Checked == true)
                    break;
            }
            if (i >= this.m_gbSearch.Controls.Count)//未选择搜索方式
            {
                MessageBox.Show("请选择搜索方式");
                this.m_tbQue.Text = "";
                return;
            }
            /*switch (i)
            {
                case 0: MessageBox.Show("标题"); break;
                case 1: MessageBox.Show("tag");break;
                case 2: MessageBox.Show("分类"); break; 
                default:    MessageBox.Show("Wrong");return;
            }*/

            searchManager tmpSearch = new searchManager();//处理搜索
            queAns = tmpSearch.kindOfSearch(i, str);
            if(queAns.Count <= 0)
            {
                MessageBox.Show("没有查询到结果");
                return;
            }
            questionBankForm = new questionBank();
            questionBankForm.init(this.queAns);
            questionBankForm.ShowDialog();
            
        }
        private void SearchQue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
