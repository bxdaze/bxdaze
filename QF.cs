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

namespace LWHY
{
    public partial class QF : Form
    {
        String tmp ;
        char classficitong = 'Q';
        //  String textpass = textBox2.Text;
        String textpass;
        FeedBack Ipass = new FeedBack();
        Userfeedback cl;
        IDataPumdUserfeedback pass = new DataPumdUserfeedback();
        public QF(Userfeedback This, String Questiontext)
        {
            tmp = Questiontext;
            InitializeComponent();
            Ipass.classfication = classficitong;
            cl = This;
            label2.Text = tmp;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                textpass = textBox2.Text;
                Ipass.description = textpass;
        }

 

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           pass.write(Ipass, Global.TheOnlyUser.userid);
            cl.Close();
            this.Close();
        }
    }
}
