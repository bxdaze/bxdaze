using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordQuestion
{
    public partial class MyForm : Form
    {
        private float X = 0.0f, Y = 0.0f;

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Form1_Resize);
            X = this.Width;
            Y = this.Height;
            this.setTag(this);
        }

        //最大化
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Top + ":" + con.Left + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                String[] mytags = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytags[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytags[1]) * newy;
                con.Height = (int)a;
                a = Convert.ToSingle(mytags[2]) * newy;
                con.Top = (int)a;
                a = Convert.ToSingle(mytags[3]) * newx;
                con.Left = (int)a;
                Single currectsize = Convert.ToSingle(mytags[4]) * newy;
                con.Font = new Font(con.Font.Name, currectsize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = (this.Height) / Y;
            setControls(newx, newy, this);
            // this.Text = this.Width.ToString() + "*" + this.Height.ToString();
        }
    }
}
