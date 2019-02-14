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
using AddTagsForm;
using LWHY题库及学习系统;
namespace LWHY_Search
{
    public partial class problem : Form
    {
        private Question m_que;
        private IDataPumpSearchQueManager m_queMan = new DataPumpSearchQueManager();
        public problem()
        {
            InitializeComponent();
        }
        public void init(int qid)
        {
            m_que = m_queMan.FindOneQuestion(qid);
            if (m_que == null)
            {
                MessageBox.Show("错误选择");
                return;
            }
            this.m_lbTitle.Text = this.m_que.title;
            this.m_lbBody.Text = this.m_que.body;
            this.m_lbAns.Text = this.m_que.answer;
            this.m_lbAns.ForeColor = Color.White;
            this.m_lbBody.ForeColor = Color.Black;
            this.m_lbTitle.ForeColor = Color.Black;
        }

        private void m_btnShowAns_Click(object sender, EventArgs e)
        {
            this.m_lbAns.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddTags fat = new FormAddTags(m_que);
            fat.Owner = this;
            this.Hide();
            fat.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_queMan.addcllection(m_que.questionId, Global.TheOnlyUser.userid);
            MessageBox.Show("收藏成功");
        }
       
    }
}
