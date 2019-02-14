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

namespace WindowsFormsUser
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
            UserManage temp_um = new UserManage(Global.TheOnlyUser);
            this.pictureBox1.BackgroundImage = temp_um.photo;
            string name = temp_um.name;
            string sex = temp_um.sex;
            string age = temp_um.age.ToString();
            string email = temp_um.email;
            string address = temp_um.address;
            string phoneNumb = temp_um.phonenum;
            string nickname = Global.TheOnlyUser.nickname;//user的Nickname要传过来
            string test = string.Format
                ("姓名：     {0}\r\r性别：     {1}\r\r年龄：     {2}\r\r昵称：     {3}\r\r电子邮件： {4}\r\r电话：     {5}\r\r地址：     {6}"
                , name, sex, age, nickname, email, phoneNumb, address);
            this.label1.Text = test;
        }

    }
}
