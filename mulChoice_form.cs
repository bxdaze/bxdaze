using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using LWHY;

namespace RecordQuestion
{
    public partial class mulChoice_form : MyForm
    {
        Question temp;
        Classification where;

        string tit;//选择题题目
        string body;//选择题题干
        List<string> choice = new List<string>();//选项
        char option_count = 'A';
        char option_show = 'A';
        int sum = -1;//选项计数器

       // private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button Chocie_up;

        public mulChoice_form()
        {
            InitializeComponent();
        }

        private void multipleChoice_form_Load(object sender, EventArgs e)
        {

        }

      /*  private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text!="") Chocie_up.Show();
        }*/


    

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(option_count == 'Z')
            {
                MessageBox.Show("超出选项数量限制！！！");
                return;
            }
            if (option_count == 'A')
            {

                    this.Chocie_up = new System.Windows.Forms.Button();

                    this.textBox1.Location = new System.Drawing.Point(181, 250);
                    this.textBox1.Multiline = true;
                    this.textBox1.Name = "textBox1";
                    this.textBox1.Size = new System.Drawing.Size(235, 39);
                    this.textBox1.TabIndex = 3;
                    textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                    this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);

                    //textbox2
                    //

                    this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
                    this.textBox2.Enabled = true;
                    this.textBox2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    this.textBox2.Location = new System.Drawing.Point(142, 250);
                    this.textBox2.Name = "textBox2";
                    this.textBox2.Size = new System.Drawing.Size(30, 34);
                    this.textBox2.TabIndex = 3;
                    this.textBox2.Text = option_count.ToString();
                    this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
              
                // Chocie_up
                // 
                this.Chocie_up.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                this.Chocie_up.Location = new System.Drawing.Point(420, 250);
                this.Chocie_up.Name = "Chocie_up";
                this.Chocie_up.Size = new System.Drawing.Size(50, 30);
                this.Chocie_up.TabIndex = 3;
                this.Chocie_up.Text = "确认";
                this.Chocie_up.UseVisualStyleBackColor = true;
                this.Chocie_up.Click += new System.EventHandler(this.Chocie_up_Click);


                this.Controls.Add(this.Chocie_up);
                this.Controls.Add(this.textBox1);
                this.Controls.Add(this.textBox2);
                Chocie_up.Visible = false;
            }
            else
            {
                this.textBox2.Text = option_count.ToString();
                choice.Add(this.textBox1.Text);
                this.textBox1.Text = "";
                Chocie_finish.Show();

                //Choice_Show
                Choice_Show.Show();
                Choice_Show.AppendText(option_show.ToString() + "." + choice[sum] + "\n");
                // Choice_Show.Text += ( option_show.ToString()+"."+ choice[sum]+"\n");
                body += ( option_show.ToString() + "." + choice[sum]+"##");
                option_show++;
            }
            option_count++;//记录按钮点击次数
            sum++;//增加选项个数计数
        }

        private void Title_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                                            tit += (Title.Text);

                                           }
        }

        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != '\0')
            {
                Chocie_up.Show();
                //Chocie_finish.Show();
            }
        }

        private void Chocie_up_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void Chocie_finish_Click(object sender, EventArgs e)
        {
            if (!(CommonCheck.CheckText(Title) && CommonCheck.CheckText(Answer) && CommonCheck.CheckText(Choice_Show)))
            {
                MessageBox.Show("请填写完整信息之后再提交！");
                return;
            }

        
            string _title = Title.Text;
            string answer = Answer.Text;

           /* MessageBox.Show(_title);
            MessageBox.Show(body);
            MessageBox.Show(answer);*/

            temp = new Question(0, _title, body, answer, "", 'c');//用于传输的question类
           IDataPumpAddquesManager Dpam = new DataPumpAddquesManager();
            Dpam.AddNewquestion(temp, where);
            MessageBox.Show("提交成功");
            this.Close();
        }

        public void SetWhere(Classification x) { where = x; }
    }
}
