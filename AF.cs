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
    public partial class AF : Form
    {
        String tmp ;
        char classficitong = 'A';
        //  String textpass = textBox2.Text;
        String textpass;
        FeedBack Ipass = new FeedBack();
        IDataPumdUserfeedback pass = new DataPumdUserfeedback();
        Userfeedback cl;
        public AF(Userfeedback cl,String Questiontext)
        {
            tmp = Questiontext;
            InitializeComponent();
            Ipass.classfication = classficitong;
            this.cl = cl;
            label2.Text = tmp;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textpass = textBox2.Text;
            Ipass.description = textpass;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pass.write(Ipass, Global.TheOnlyUser.userid);
            cl.Close();
            this.Close();
        }
    }
}
