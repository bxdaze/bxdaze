using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using LWHY;

namespace 注册界面
{
    public partial class FormSignup : Form
    {
        static bool NicknameAvailable; // 用户名有效
        static bool PasswordAvailable; // 密码有效
        static bool EnsurepasswordAvailable; // 确认密码有效
        static bool AgeAvailable; // 年龄有效
        static bool MailboxAvailable; // 邮箱有效
        static bool IDNumberAvailable; // 身份证号有效
        static bool MobilenumberAvailable; // 手机号有效
        static bool NameAvailable; // 姓名有效
        static bool AddressAvailable; // 地址有效
        static bool JobAvailable; // 职业有效
        static bool WorkspaceAvailable; // 工作单位有效
        static bool PhotoAvailable; // 头像有效
        public FormSignup()
        {
            NicknameAvailable = false;
            PasswordAvailable = false;
            EnsurepasswordAvailable = false;
            AgeAvailable = false;
            MailboxAvailable = false;
            IDNumberAvailable = false;
            MobilenumberAvailable = false;
            NameAvailable = false;
            AddressAvailable = false;
            JobAvailable = false;
            WorkspaceAvailable = false;
            PhotoAvailable = false;
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            IDataPumpRegisterManager IDPRM = new DataPumpRegisterManager();
            bool temp_InformationCompleted = true;
            temp_InformationCompleted &= NicknameAvailable;
            temp_InformationCompleted &= PasswordAvailable;
            temp_InformationCompleted &= EnsurepasswordAvailable;
            temp_InformationCompleted &= AgeAvailable;
            temp_InformationCompleted &= MailboxAvailable;
            temp_InformationCompleted &= IDNumberAvailable;
            temp_InformationCompleted &= MobilenumberAvailable;
            temp_InformationCompleted &= NameAvailable;
            temp_InformationCompleted &= JobAvailable;
            temp_InformationCompleted &= WorkspaceAvailable;
            temp_InformationCompleted &= AddressAvailable;
            temp_InformationCompleted &= PhotoAvailable;
            temp_InformationCompleted &= !IDPRM.checkName(TextBoxNickname.Text);
            if (!temp_InformationCompleted)
            {
                MessageBoxButtons temp_OKButton = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("信息填写不符合要求", "返回", temp_OKButton);
                if (dr == DialogResult.OK) ;
            }
                /*
            else if ()
            {
                MessageBoxButtons temp_OKButton = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("用户名已存在", "返回", temp_OKButton);
                if (dr == DialogResult.OK) ;
            }
                 */
            else
            {
                User temp_userinformation = new User();
                temp_userinformation.nickname = TextBoxNickname.Text;
                temp_userinformation.password = TextBoxPassword.Text;
                Information temp_registerinformation = new Information();
                temp_registerinformation.name = TextBoxName.Text;
                temp_registerinformation.idcardnum = TextBoxIDNumber.Text;
                temp_registerinformation.phonenum = TextBoxMobilenumber.Text;
                temp_registerinformation.address = TextBoxAddress.Text;
                if (ButtonMale.Checked) temp_registerinformation.sex = 'M';
                else temp_registerinformation.sex = 'F';
                temp_registerinformation.age = Convert.ToInt32(TextBoxAge.Text);
                temp_registerinformation.email = TextBoxMailbox.Text;
                temp_registerinformation.role ='U';
                temp_registerinformation.photo = PictureBoxPhoto.Image;
                IDPRM.updateRegisterInformation(temp_userinformation, temp_registerinformation);
                MessageBoxButtons temp_OKButton = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("注册成功", "退出", temp_OKButton);
                if (dr == DialogResult.OK) Close();
                
            }
        }

        private void TextBoxNickname_TextChanged(object sender, EventArgs e)
        {
            Regex temp_NicknameJudgement = new Regex("^[\u4e00-\u9fa5a-zA-Z0-9]{3,16}$");
            if (TextBoxNickname.Text == "")
            {
                LabelEmptyNickname.Visible = true;
                LabelErrorNickname.Visible = false;
                PasswordAvailable = false;
            }
            else if (!temp_NicknameJudgement.IsMatch(TextBoxNickname.Text))
            {
                LabelErrorNickname.Visible = true;
                LabelEmptyNickname.Visible = false;
                PasswordAvailable = false;
            }
            else
            {
                LabelErrorNickname.Visible = false;
                LabelEmptyNickname.Visible = false;
                NicknameAvailable = true;
            }
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            Regex temp_PasswordJudgement = new Regex(@"^[0-9a-zA-z_]{6,20}$");
            if (TextBoxPassword.Text == "")
            {
                LabelEmptyPassword.Visible = true;
                LabelErrorPassword.Visible = false;
                PasswordAvailable = false;
            }
            else if (!temp_PasswordJudgement.IsMatch(TextBoxPassword.Text))
            {
                LabelEmptyPassword.Visible = false;
                LabelErrorPassword.Visible = true;
                PasswordAvailable = false;
            }
            else
            {
                LabelEmptyPassword.Visible = false;
                LabelErrorPassword.Visible = false;
                PasswordAvailable = true;
            }
        }

        private void TextBoxAge_TextChanged(object sender, EventArgs e)
        {
            Regex temp_AgeJudge = new Regex("^[0-9]{1,2}$");
            if (TextBoxAge.Text == "")
            {
                LabelEmptyAge.Visible = true;
                LabelErrorAge.Visible = false;
                AgeAvailable = false;
            }
            else if (!temp_AgeJudge.IsMatch(TextBoxAge.Text))
            {
                AgeAvailable = false;
                LabelEmptyAge.Visible = false;
                LabelErrorAge.Visible = true;
            }
            else
            {
                AgeAvailable = true;
                LabelEmptyAge.Visible = false;
                LabelErrorAge.Visible = false;
            }
        }

        private void TextboxMailbox_TextChanged(object sender, EventArgs e)
        {
            Regex temp_MailboxJudge = new Regex("^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$");
            if (TextBoxMailbox.Text == "")
            {
                LabelEmptyMailBox.Visible = true;
                LabelErrorMailbox.Visible = false;
                MailboxAvailable = false;
            }
            else if (!temp_MailboxJudge.IsMatch(TextBoxMailbox.Text))
            {
                MailboxAvailable = false;
                LabelErrorMailbox.Visible = true;
                LabelEmptyMailBox.Visible = false;
            }
            else
            {
                MailboxAvailable = true;
                LabelErrorMailbox.Visible = false;
                LabelEmptyMailBox.Visible = false;
            }
        }

        private void TextBoxIDNumber_TextChanged(object sender, EventArgs e)
        {
            Regex temp_IDNumberJudge = new Regex("^[1-9]\\d{5}[1-9]\\d{3}((0\\d)|(1[0-2]))(([0|1|2]\\d)|3[0-1])\\d{3}([0-9]|X)$");
            if (TextBoxIDNumber.Text == "")
            {
                LabelErrorIDNumber.Visible = false;
                LabelEmptyIDNumber.Visible = true;
                IDNumberAvailable = false;
            }
            if (!temp_IDNumberJudge.IsMatch(TextBoxIDNumber.Text))
            {
                IDNumberAvailable = false;
                LabelEmptyIDNumber.Visible = false;
                LabelErrorIDNumber.Visible = true;
            }
            else
            {
                IDNumberAvailable = true;
                LabelEmptyIDNumber.Visible = false;
                LabelErrorIDNumber.Visible = false;
            }
        }

        private void TextBoxMobilenumber_TextChanged(object sender, EventArgs e)
        {
            Regex temp_MobilenumberJudge = new Regex("^((13[0-9])|(14[5|7])|(15([0-3,5-9]))|(18[0,5-9]))\\d{8}$");
            if (TextBoxMobilenumber.Text == "")
            {
                LabelErrorMobileNumber.Visible = false;
                LabelEmptyMobilenumber.Visible = true;
                MobilenumberAvailable = false;
            }
            else if (!temp_MobilenumberJudge.IsMatch(TextBoxMobilenumber.Text)) {
                MobilenumberAvailable = false;
                LabelEmptyMobilenumber.Visible = false;
                LabelErrorMobileNumber.Visible = true;
            }
            else
            {
                LabelEmptyMobilenumber.Visible = false;
                MobilenumberAvailable = true;
                LabelErrorMobileNumber.Visible = false;
            }
        }

        private void TextBoxEnsurepassword_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxEnsurepassword.Text == "")
            {
                EnsurepasswordAvailable = false;
                LabelEmptyEnsurepassword.Visible = true;
                LabelErrorEnsurepassword.Visible = false;
            }
            else if (Equals(TextBoxPassword.Text, TextBoxEnsurepassword.Text))
            {
                EnsurepasswordAvailable = true;
                LabelEmptyEnsurepassword.Visible = false;
                LabelErrorEnsurepassword.Visible = false;
            } 
            else
            {
                EnsurepasswordAvailable = false;
                LabelEmptyEnsurepassword.Visible = false;
                LabelErrorEnsurepassword.Visible= true;
            }
        }

        private void ButtonUpdatePhoto_Click(object sender, EventArgs e)
        {
            //创建一个对话框对象
            OpenFileDialog ofd = new OpenFileDialog();
            //为对话框设置标题
            ofd.Title = "请选择上传的图片";
            //设置筛选的图片格式
            ofd.Filter = "图片格式|*.jpg";
            //设置是否允许多选
            ofd.Multiselect = false;
            //如果你点了“确定”按钮
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //获得文件的完整路径（包括名字后后缀）
                string filePath = ofd.FileName;
                //将文件路径显示在文本框中
                //txtImgUrl.Text = filePath;
                //找到文件名比如“1.jpg”前面的那个“\”的位置
                int position = filePath.LastIndexOf("\\");
                //从完整路径中截取出来文件名“1.jpg”
                string fileName = filePath.Substring(position + 1);
                PictureBoxPhoto.ImageLocation = fileName;
                LabelEmptyPhoto.Visible = false;
                PhotoAvailable = true;
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "")
            {
                LabelEmptyName.Visible = true;
                NameAvailable = false;
            }
            else
            {
                LabelEmptyName.Visible = false;
                NameAvailable = true;
            }
        }

        private void TextBoxWorkspace_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxWorkspace.Text == "")
            {
                LabelEmptyWorkspace.Visible = true;
                WorkspaceAvailable = false;
            }
            else
            {
                LabelEmptyWorkspace.Visible = false;
                WorkspaceAvailable = true;
            }
        }

        private void TextBoxJob_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxJob.Text == "")
            {
                LabelEmptyJob.Visible = true;
                JobAvailable = false;
            }
            else
            {
                LabelEmptyJob.Visible = false;
                JobAvailable = true;
            }
        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxAddress.Text == "")
            {
                LabelEmptyAddress.Visible = true;
                AddressAvailable = false;
            }
            else
            {
                LabelEmptyAddress.Visible = false;
                AddressAvailable = true;
            }
        }
    }
}
