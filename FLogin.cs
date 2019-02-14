using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 注册界面;
using LWHY题库及学习系统;
using WindowsFormsUser;




namespace WindowsFormsApp_login
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            string temp_User = this.tB_User.Text;
            string temp_Password = this.tB_Password.Text;
            if (isRight(temp_User) == 1 && isRight(temp_Password) == 1)
            {
                LoginManager temp_LoginManager = new LoginManager();
                int temp_Manage = temp_LoginManager.isLogin(temp_User, temp_Password);
                switch (temp_Manage)
                {
                    case 1:
                        { 
                            MessageBox.Show("登录成功");

                            this.DialogResult = DialogResult.OK;
                            
                            
                        } break;
                    case 2:MessageBox.Show("密码错误");break;
                    case 3:MessageBox.Show("用户已登录");break;
                    case 4:MessageBox.Show("用户不存在");break;
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            
        }

        private void b_Register_Click(object sender, EventArgs e)
        {
            FormSignup fm = new FormSignup();
            fm.Show();
        }

        private void tB_Password_TextChanged(object sender, EventArgs e)//密码隐藏
        {
            if (cB_Password.Checked)
            {
                this.tB_Password.PasswordChar = Convert.ToChar(0);
            }
            else
            {
                this.tB_Password.PasswordChar = '*';
            }
        }

        private void cB_Password_CheckedChanged(object sender, EventArgs e)//通过勾选显示密码
        {
            if (cB_Password.Checked)
            {
                this.tB_Password.PasswordChar = Convert.ToChar(0);
            }
            else
            {
                this.tB_Password.PasswordChar = '*';
            }
        }

        private void tB_KeyPress(object sender, KeyPressEventArgs e)//控制密码不能输入空格
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private int isRight(string temp_String)//判断输入合法性
        {
            if (temp_String.Length >= 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

     

        private void FLogin_Load_1(object sender, EventArgs e)
        {

        }
 

        
    }
}
