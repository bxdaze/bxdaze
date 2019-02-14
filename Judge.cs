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
    
    public partial class Judge : MyForm
    {
        Question temp;
        Classification where;
        String answer = "x";
        public Judge()
        {
            InitializeComponent();
        }

        private void Chocie_finish_Click(object sender, EventArgs e)
        {
            if (!(CommonCheck.CheckText(Title) && answer != "x"))
            {
                MessageBox.Show("请填写完整信息之后再提交！");
                return;
            }

            string _title = Title.Text;


            temp = new Question(0,_title,"",answer,"", 'b');
            IDataPumpAddquesManager Dpam = new DataPumpAddquesManager();
            Dpam.AddNewquestion(temp, where);
            MessageBox.Show("提交成功");
            this.Close();
        }




        public void SetWhere(Classification x) { where = x; }

        private void Answer_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer = "T";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer = "F";
        }

        private void Title_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\0')
            {
                Chocie_finish.Show();
                //Chocie_finish.Show();
            }
        }
    }
}
