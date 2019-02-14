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

namespace RecordQuestion
{
    
    public partial class Blank : Form
    {

        Question temp;
        Classification where;
        public Blank()
        {
            InitializeComponent();
        }

        private void Blank_Load(object sender, EventArgs e)
        {

        }

        private void Chocie_finish_Click(object sender, EventArgs e)
        {
            string _title = Title.Text;
            string answer = Answer.Text;

            if((_title=="")|| answer=="")
            {
                MessageBox.Show("请填写完整信息之后再提交！");
                return;
            }

            temp = new Question(0, _title, "", answer, "", 'e');//传输的question类
            IDataPumpAddquesManager Dpam = new DataPumpAddquesManager();
            Dpam.AddNewquestion(temp, where);
            MessageBox.Show("提交成功");
            this.Close();

        }



        private void Answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\0')
            {

                Chocie_finish.Show();
            }
        }

        public void SetWhere(Classification x) { where = x; }

        private void Chocie_finish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\0')
            {
                Chocie_finish.Show();
                //Chocie_finish.Show();
            }
        }
    }
}
