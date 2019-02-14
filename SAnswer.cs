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
    

    public partial class SAnswer : MyForm
    {
        bool[] eror;
        Question temp;
        Classification where;

        public SAnswer()
        {
            InitializeComponent();
        }

        private void Chocie_finish_Click(object sender, EventArgs e)
        {
            if (!(CommonCheck.CheckText(Title) && CommonCheck.CheckText(Answer)))
            {
                MessageBox.Show("请填写完整信息之后再提交！");
                return;
            }

            string _title = Title.Text;
            string answer = Answer.Text;

          

            temp = new Question(0,_title, "",answer,"",'d' );//用于传输的question类
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

        private void Chocie_finish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\0')
            {

                Chocie_finish.Show();
            }
        }

        public void SetWhere(Classification x) { where = x; }
    }
}
