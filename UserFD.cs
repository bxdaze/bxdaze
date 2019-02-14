using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LWHY
{
    public partial class Userfeedback : Form
    {
        private  String Questiontext="I am xiaoming";//用来存储题目文本
        public void WriteQuestiontext(String tmp)
        {
            Questiontext = tmp;
        }
        public Userfeedback()
        {
            
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            QF Form2 = new QF(this,Questiontext);
            Form2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AF Form3 = new AF(this,Questiontext);
            Form3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OF Form4 = new OF(this,Questiontext);
            Form4.Show();
       
        }
        private void UserFD_Closing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
         }
    }
}
