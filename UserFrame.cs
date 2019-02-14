using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LWHY题库及学习系统;
using LWHY_Search;
using RecordQuestion;
using LWHY_test;
using LWHY;

namespace WindowsFormsUser
{
    public partial class UserFrame : Form
    {
        public UserFrame()
        {
            InitializeComponent();
            this.linkLabel1.Text = Global.TheOnlyUser.nickname;
            
                
                //这里还没写注销的逻辑。
           
            
        }

        private void button1_Click(object sender, EventArgs e)//搜题
        {
            SearchQue sq = new SearchQue();
            sq.Owner = this;
            this.Hide();
            sq.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//录题
        {
            Type_form tf=new Type_form();
            tf.Owner=this;
            this.Hide();
            tf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//刷题
        {
            Modelchose mc=new Modelchose();
            mc.Owner=this;
            this.Hide();
            mc.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)//反馈
        {
            Userfeedback ub = new Userfeedback();
            ub.Owner = this;
            this.Hide();
            ub.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)//查看我已收藏的题
        {
            ShowMyQuestionForm temp_showMyQuestionForm = new ShowMyQuestionForm();
            temp_showMyQuestionForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserInfoForm temp_UserInfo = new UserInfoForm();
            temp_UserInfo.ShowDialog();
        }

        
        
    }
}
