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
    public partial class questionBank : Form
    {
        private List<Question> m_questions;
        private int page = 0;
        private int maxPage;
        private problem form_p;
        public questionBank()
        {
            InitializeComponent();
        }
        private int min(int a, int b)
        {
            return a > b ? b : a;
        }
        public void init(List<Question> tmp)//-------------------?
        {
            m_questions = tmp;

            for (int i = 0; i < 11; i++)//第一行显示每列属性，一次显示十道题目
                this.m_dgvQueBank.Rows.Add();

            //首页题库显示
            this.page = 1;
            for (int i = 1; i < min(11,this.m_questions.Count()+1); i++)
            {
                
                this.m_dgvQueBank.Rows[i].Cells[0].Value = " ";
                this.m_dgvQueBank.Rows[i].Cells[1].Value = this.m_questions[i - 1].questionId;
                this.m_dgvQueBank.Rows[i].Cells[2].Value = this.m_questions[i - 1].title;
                this.m_dgvQueBank.Rows[i].Cells[3].Value = this.m_questions[i - 1].tags;
            }
            //页号显示
            this.maxPage = (int)Math.Floor(Convert.ToDouble(this.m_questions.Count() / 10.0))+1;
            this.m_tbPages.Text = maxPage.ToString();
            this.m_tbPages.ForeColor = Color.Gray;
        }



        private void m_tbPages_TextChanged(object sender, EventArgs e)
        
        {
            this.m_tbPages.ForeColor = System.Drawing.Color.Black;
        }

        private void m_btnGoto_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.m_tbPages.Text) > this.maxPage)
            {
                MessageBox.Show("输入页数过大！请重新输入");
                this.m_tbPages.Text = maxPage.ToString();
                this.m_tbPages.ForeColor = Color.Gray;
                return;
            }
            this.page = int.Parse(this.m_tbPages.Text);
            int tmp = (this.page - 1) * 10;
            for (int i = 1; i < min(11, this.m_questions.Count() + 1); i++)
            {
                if ((tmp + i - 1) > this.m_questions.Count())
                    break;
                this.m_dgvQueBank.Rows[i].Cells[0].Value = " ";
                this.m_dgvQueBank.Rows[i].Cells[1].Value = this.m_questions[tmp + i - 1].questionId;
                this.m_dgvQueBank.Rows[i].Cells[2].Value = this.m_questions[tmp + i - 1].title;
                this.m_dgvQueBank.Rows[i].Cells[3].Value = this.m_questions[tmp + i - 1].tags;
            }
            this.m_tbPages.Text = maxPage.ToString();
            this.m_tbPages.ForeColor = System.Drawing.Color.Gray;
        }

        private void m_llTop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.page = 1;
            for (int i = 1; i < min(11, this.m_questions.Count() + 1); i++)
            {
                this.m_dgvQueBank.Rows[i].Cells[0].Value = " ";
                this.m_dgvQueBank.Rows[i].Cells[1].Value = this.m_questions[i - 1].questionId;
                this.m_dgvQueBank.Rows[i].Cells[2].Value = this.m_questions[i - 1].title;
                this.m_dgvQueBank.Rows[i].Cells[3].Value = this.m_questions[i - 1].tags;
            }
            this.m_tbPages.Text = maxPage.ToString();
            this.m_tbPages.ForeColor = System.Drawing.Color.Gray;
        }

        private void m_llPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.page <= 1)
            {
                MessageBox.Show("已到第一页");
                return;
            }
            this.page -= 1;
            int tmp = (this.page - 1) * 10;
            for (int i = 1; i < min(11, this.m_questions.Count() + 1); i++)
            {
                if ((tmp + i - 1) > this.m_questions.Count())
                    break;
                this.m_dgvQueBank.Rows[i].Cells[0].Value = " ";
                this.m_dgvQueBank.Rows[i].Cells[1].Value = this.m_questions[tmp + i - 1].questionId;
                this.m_dgvQueBank.Rows[i].Cells[2].Value = this.m_questions[tmp + i - 1].title;
                this.m_dgvQueBank.Rows[i].Cells[3].Value = this.m_questions[tmp + i - 1].tags;
            }
            this.m_tbPages.Text = maxPage.ToString();
            this.m_tbPages.ForeColor = System.Drawing.Color.Gray;
        }

        private void m_llNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.page >= this.maxPage)
            {
                MessageBox.Show("已到最后一页");
                return;
            }
            this.page += 1;
            int tmp = (this.page - 1) * 10;
            for (int i = 1; i < min(11, this.m_questions.Count() + 1); i++)
            {
                if ((tmp + i - 1) > this.m_questions.Count())
                    break;
                this.m_dgvQueBank.Rows[i].Cells[0].Value = " ";
                this.m_dgvQueBank.Rows[i].Cells[1].Value = this.m_questions[tmp + i - 1].questionId;
                this.m_dgvQueBank.Rows[i].Cells[2].Value = this.m_questions[tmp + i - 1].title;
                this.m_dgvQueBank.Rows[i].Cells[3].Value = this.m_questions[tmp + i - 1].tags;
            }
            this.m_tbPages.Text = maxPage.ToString();
            this.m_tbPages.ForeColor = System.Drawing.Color.Gray;
        }

        private void m_llEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.page = this.maxPage;
            int tmp = (this.page - 1) * 10;
            for (int i = 1; i < min(11, this.m_questions.Count() + 1); i++)
            {
                if ((tmp + i - 1) > this.m_questions.Count())
                    break;

                this.m_dgvQueBank.Rows[i].Cells[0].Value = " ";
                this.m_dgvQueBank.Rows[i].Cells[1].Value = this.m_questions[tmp + i - 1].questionId;
                this.m_dgvQueBank.Rows[i].Cells[2].Value = this.m_questions[tmp + i - 1].title;
                this.m_dgvQueBank.Rows[i].Cells[3].Value = this.m_questions[tmp + i - 1].tags;
            }
            this.m_tbPages.Text = maxPage.ToString();
            this.m_tbPages.ForeColor = System.Drawing.Color.Gray;
        }

        private void m_dgvQueBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = this.m_dgvQueBank.CurrentCell.RowIndex;
            this.form_p = new problem();
            form_p.init(Convert.ToInt32(this.m_dgvQueBank.Rows[n].Cells[1].Value));
            form_p.Show();
        }
    }
}
