namespace 注册界面
{
    partial class FormSignup
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignup));
            this.LabelNickname = new System.Windows.Forms.Label();
            this.TextBoxNickname = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxEnsurepassword = new System.Windows.Forms.TextBox();
            this.LabelEnsurepassword = new System.Windows.Forms.Label();
            this.LableAge = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelPersonalname = new System.Windows.Forms.Label();
            this.LabelPersonalInformation = new System.Windows.Forms.Label();
            this.LabelBasicInformation = new System.Windows.Forms.Label();
            this.TextBoxJob = new System.Windows.Forms.TextBox();
            this.LabelJob = new System.Windows.Forms.Label();
            this.TextBoxMobilenumber = new System.Windows.Forms.TextBox();
            this.LabelMobilenumber = new System.Windows.Forms.Label();
            this.TextBoxIDNumber = new System.Windows.Forms.TextBox();
            this.LabelIDNumber = new System.Windows.Forms.Label();
            this.TextBoxMailbox = new System.Windows.Forms.TextBox();
            this.LabelMailbox = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.TextBoxWorkspace = new System.Windows.Forms.TextBox();
            this.LabelWorkspace = new System.Windows.Forms.Label();
            this.ButtonMale = new System.Windows.Forms.RadioButton();
            this.PanelChooseSex = new System.Windows.Forms.Panel();
            this.ButtonFemale = new System.Windows.Forms.RadioButton();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.LabelPhoto = new System.Windows.Forms.Label();
            this.ButtonUpdatePhoto = new System.Windows.Forms.Button();
            this.LabelErrorPassword = new System.Windows.Forms.Label();
            this.LabelErrorMailbox = new System.Windows.Forms.Label();
            this.LabelErrorEnsurepassword = new System.Windows.Forms.Label();
            this.LabelErrorAge = new System.Windows.Forms.Label();
            this.LabelErrorIDNumber = new System.Windows.Forms.Label();
            this.LabelErrorMobileNumber = new System.Windows.Forms.Label();
            this.LabelEmptyPhoto = new System.Windows.Forms.Label();
            this.LabelEmptyName = new System.Windows.Forms.Label();
            this.LabelEmptyAddress = new System.Windows.Forms.Label();
            this.LabelEmptyMailBox = new System.Windows.Forms.Label();
            this.LabelEmptyWorkspace = new System.Windows.Forms.Label();
            this.LabelEmptyJob = new System.Windows.Forms.Label();
            this.LabelEmptyMobilenumber = new System.Windows.Forms.Label();
            this.LabelEmptyIDNumber = new System.Windows.Forms.Label();
            this.LabelEmptyNickname = new System.Windows.Forms.Label();
            this.LabelEmptyPassword = new System.Windows.Forms.Label();
            this.LabelEmptyEnsurepassword = new System.Windows.Forms.Label();
            this.LabelEmptyAge = new System.Windows.Forms.Label();
            this.LabelErrorNickname = new System.Windows.Forms.Label();
            this.PanelChooseSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNickname
            // 
            this.LabelNickname.AutoSize = true;
            this.LabelNickname.BackColor = System.Drawing.Color.Transparent;
            this.LabelNickname.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelNickname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelNickname.Location = new System.Drawing.Point(30, 77);
            this.LabelNickname.Name = "LabelNickname";
            this.LabelNickname.Size = new System.Drawing.Size(49, 20);
            this.LabelNickname.TabIndex = 0;
            this.LabelNickname.Text = "昵称";
            // 
            // TextBoxNickname
            // 
            this.TextBoxNickname.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxNickname.Location = new System.Drawing.Point(120, 72);
            this.TextBoxNickname.Name = "TextBoxNickname";
            this.TextBoxNickname.Size = new System.Drawing.Size(298, 25);
            this.TextBoxNickname.TabIndex = 1;
            this.TextBoxNickname.TextChanged += new System.EventHandler(this.TextBoxNickname_TextChanged);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxPassword.Location = new System.Drawing.Point(120, 121);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(298, 25);
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPassword.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelPassword.Location = new System.Drawing.Point(30, 126);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(49, 20);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "密码";
            // 
            // TextBoxEnsurepassword
            // 
            this.TextBoxEnsurepassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxEnsurepassword.Location = new System.Drawing.Point(120, 170);
            this.TextBoxEnsurepassword.Name = "TextBoxEnsurepassword";
            this.TextBoxEnsurepassword.PasswordChar = '*';
            this.TextBoxEnsurepassword.Size = new System.Drawing.Size(298, 25);
            this.TextBoxEnsurepassword.TabIndex = 5;
            this.TextBoxEnsurepassword.TextChanged += new System.EventHandler(this.TextBoxEnsurepassword_TextChanged);
            // 
            // LabelEnsurepassword
            // 
            this.LabelEnsurepassword.AutoSize = true;
            this.LabelEnsurepassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelEnsurepassword.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelEnsurepassword.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelEnsurepassword.Location = new System.Drawing.Point(30, 175);
            this.LabelEnsurepassword.Name = "LabelEnsurepassword";
            this.LabelEnsurepassword.Size = new System.Drawing.Size(89, 20);
            this.LabelEnsurepassword.TabIndex = 4;
            this.LabelEnsurepassword.Text = "确认密码";
            // 
            // LableAge
            // 
            this.LableAge.AutoSize = true;
            this.LableAge.BackColor = System.Drawing.Color.Transparent;
            this.LableAge.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LableAge.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableAge.Location = new System.Drawing.Point(30, 371);
            this.LableAge.Name = "LableAge";
            this.LableAge.Size = new System.Drawing.Size(49, 20);
            this.LableAge.TabIndex = 10;
            this.LableAge.Text = "年龄";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.BackColor = System.Drawing.Color.Transparent;
            this.LabelSex.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSex.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelSex.Location = new System.Drawing.Point(30, 322);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(49, 20);
            this.LabelSex.TabIndex = 8;
            this.LabelSex.Text = "性别";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxName.Location = new System.Drawing.Point(120, 273);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(298, 25);
            this.TextBoxName.TabIndex = 7;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // LabelPersonalname
            // 
            this.LabelPersonalname.AutoSize = true;
            this.LabelPersonalname.BackColor = System.Drawing.Color.Transparent;
            this.LabelPersonalname.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPersonalname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelPersonalname.Location = new System.Drawing.Point(30, 278);
            this.LabelPersonalname.Name = "LabelPersonalname";
            this.LabelPersonalname.Size = new System.Drawing.Size(49, 20);
            this.LabelPersonalname.TabIndex = 6;
            this.LabelPersonalname.Text = "姓名";
            // 
            // LabelPersonalInformation
            // 
            this.LabelPersonalInformation.AutoSize = true;
            this.LabelPersonalInformation.BackColor = System.Drawing.Color.Transparent;
            this.LabelPersonalInformation.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPersonalInformation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelPersonalInformation.Location = new System.Drawing.Point(203, 219);
            this.LabelPersonalInformation.Name = "LabelPersonalInformation";
            this.LabelPersonalInformation.Size = new System.Drawing.Size(133, 30);
            this.LabelPersonalInformation.TabIndex = 12;
            this.LabelPersonalInformation.Text = "个人信息";
            // 
            // LabelBasicInformation
            // 
            this.LabelBasicInformation.AutoSize = true;
            this.LabelBasicInformation.BackColor = System.Drawing.Color.Transparent;
            this.LabelBasicInformation.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelBasicInformation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelBasicInformation.Location = new System.Drawing.Point(203, 18);
            this.LabelBasicInformation.Name = "LabelBasicInformation";
            this.LabelBasicInformation.Size = new System.Drawing.Size(133, 30);
            this.LabelBasicInformation.TabIndex = 13;
            this.LabelBasicInformation.Text = "基本信息";
            // 
            // TextBoxJob
            // 
            this.TextBoxJob.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxJob.Location = new System.Drawing.Point(120, 513);
            this.TextBoxJob.Name = "TextBoxJob";
            this.TextBoxJob.Size = new System.Drawing.Size(298, 25);
            this.TextBoxJob.TabIndex = 19;
            this.TextBoxJob.TextChanged += new System.EventHandler(this.TextBoxJob_TextChanged);
            // 
            // LabelJob
            // 
            this.LabelJob.AutoSize = true;
            this.LabelJob.BackColor = System.Drawing.Color.Transparent;
            this.LabelJob.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelJob.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelJob.Location = new System.Drawing.Point(30, 518);
            this.LabelJob.Name = "LabelJob";
            this.LabelJob.Size = new System.Drawing.Size(49, 20);
            this.LabelJob.TabIndex = 18;
            this.LabelJob.Text = "职业";
            // 
            // TextBoxMobilenumber
            // 
            this.TextBoxMobilenumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxMobilenumber.Location = new System.Drawing.Point(120, 464);
            this.TextBoxMobilenumber.Name = "TextBoxMobilenumber";
            this.TextBoxMobilenumber.Size = new System.Drawing.Size(298, 25);
            this.TextBoxMobilenumber.TabIndex = 17;
            this.TextBoxMobilenumber.TextChanged += new System.EventHandler(this.TextBoxMobilenumber_TextChanged);
            // 
            // LabelMobilenumber
            // 
            this.LabelMobilenumber.AutoSize = true;
            this.LabelMobilenumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelMobilenumber.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMobilenumber.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelMobilenumber.Location = new System.Drawing.Point(30, 469);
            this.LabelMobilenumber.Name = "LabelMobilenumber";
            this.LabelMobilenumber.Size = new System.Drawing.Size(69, 20);
            this.LabelMobilenumber.TabIndex = 16;
            this.LabelMobilenumber.Text = "手机号";
            // 
            // TextBoxIDNumber
            // 
            this.TextBoxIDNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxIDNumber.Location = new System.Drawing.Point(120, 415);
            this.TextBoxIDNumber.Name = "TextBoxIDNumber";
            this.TextBoxIDNumber.Size = new System.Drawing.Size(298, 25);
            this.TextBoxIDNumber.TabIndex = 15;
            this.TextBoxIDNumber.TextChanged += new System.EventHandler(this.TextBoxIDNumber_TextChanged);
            // 
            // LabelIDNumber
            // 
            this.LabelIDNumber.AutoSize = true;
            this.LabelIDNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelIDNumber.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelIDNumber.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelIDNumber.Location = new System.Drawing.Point(30, 420);
            this.LabelIDNumber.Name = "LabelIDNumber";
            this.LabelIDNumber.Size = new System.Drawing.Size(89, 20);
            this.LabelIDNumber.TabIndex = 14;
            this.LabelIDNumber.Text = "身份证号";
            // 
            // TextBoxMailbox
            // 
            this.TextBoxMailbox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxMailbox.Location = new System.Drawing.Point(120, 660);
            this.TextBoxMailbox.Name = "TextBoxMailbox";
            this.TextBoxMailbox.Size = new System.Drawing.Size(298, 25);
            this.TextBoxMailbox.TabIndex = 25;
            this.TextBoxMailbox.TextChanged += new System.EventHandler(this.TextboxMailbox_TextChanged);
            // 
            // LabelMailbox
            // 
            this.LabelMailbox.AutoSize = true;
            this.LabelMailbox.BackColor = System.Drawing.Color.Transparent;
            this.LabelMailbox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMailbox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelMailbox.Location = new System.Drawing.Point(30, 665);
            this.LabelMailbox.Name = "LabelMailbox";
            this.LabelMailbox.Size = new System.Drawing.Size(49, 20);
            this.LabelMailbox.TabIndex = 24;
            this.LabelMailbox.Text = "邮箱";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxAddress.Location = new System.Drawing.Point(120, 611);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(298, 25);
            this.TextBoxAddress.TabIndex = 23;
            this.TextBoxAddress.TextChanged += new System.EventHandler(this.TextBoxAddress_TextChanged);
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddress.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelAddress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelAddress.Location = new System.Drawing.Point(30, 616);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(49, 20);
            this.LabelAddress.TabIndex = 22;
            this.LabelAddress.Text = "地址";
            // 
            // TextBoxWorkspace
            // 
            this.TextBoxWorkspace.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxWorkspace.Location = new System.Drawing.Point(120, 562);
            this.TextBoxWorkspace.Name = "TextBoxWorkspace";
            this.TextBoxWorkspace.Size = new System.Drawing.Size(298, 25);
            this.TextBoxWorkspace.TabIndex = 21;
            this.TextBoxWorkspace.TextChanged += new System.EventHandler(this.TextBoxWorkspace_TextChanged);
            // 
            // LabelWorkspace
            // 
            this.LabelWorkspace.AutoSize = true;
            this.LabelWorkspace.BackColor = System.Drawing.Color.Transparent;
            this.LabelWorkspace.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelWorkspace.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelWorkspace.Location = new System.Drawing.Point(30, 567);
            this.LabelWorkspace.Name = "LabelWorkspace";
            this.LabelWorkspace.Size = new System.Drawing.Size(89, 20);
            this.LabelWorkspace.TabIndex = 20;
            this.LabelWorkspace.Text = "工作单位";
            // 
            // ButtonMale
            // 
            this.ButtonMale.AutoSize = true;
            this.ButtonMale.Checked = true;
            this.ButtonMale.Location = new System.Drawing.Point(0, 1);
            this.ButtonMale.Name = "ButtonMale";
            this.ButtonMale.Size = new System.Drawing.Size(43, 19);
            this.ButtonMale.TabIndex = 26;
            this.ButtonMale.TabStop = true;
            this.ButtonMale.Text = "男";
            this.ButtonMale.UseVisualStyleBackColor = true;
            // 
            // PanelChooseSex
            // 
            this.PanelChooseSex.BackColor = System.Drawing.Color.Transparent;
            this.PanelChooseSex.Controls.Add(this.ButtonFemale);
            this.PanelChooseSex.Controls.Add(this.ButtonMale);
            this.PanelChooseSex.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PanelChooseSex.Location = new System.Drawing.Point(181, 322);
            this.PanelChooseSex.Name = "PanelChooseSex";
            this.PanelChooseSex.Size = new System.Drawing.Size(177, 20);
            this.PanelChooseSex.TabIndex = 27;
            // 
            // ButtonFemale
            // 
            this.ButtonFemale.AutoSize = true;
            this.ButtonFemale.Location = new System.Drawing.Point(85, 1);
            this.ButtonFemale.Name = "ButtonFemale";
            this.ButtonFemale.Size = new System.Drawing.Size(43, 19);
            this.ButtonFemale.TabIndex = 27;
            this.ButtonFemale.Text = "女";
            this.ButtonFemale.UseVisualStyleBackColor = true;
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextBoxAge.Location = new System.Drawing.Point(120, 366);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(298, 25);
            this.TextBoxAge.TabIndex = 11;
            this.TextBoxAge.TextChanged += new System.EventHandler(this.TextBoxAge_TextChanged);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEnter.BackgroundImage")));
            this.ButtonEnter.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonEnter.Location = new System.Drawing.Point(770, 665);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(134, 41);
            this.ButtonEnter.TabIndex = 28;
            this.ButtonEnter.Text = "确定";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxPhoto.BackgroundImage")));
            this.PictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxPhoto.Location = new System.Drawing.Point(700, 77);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(239, 233);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPhoto.TabIndex = 30;
            this.PictureBoxPhoto.TabStop = false;
            // 
            // LabelPhoto
            // 
            this.LabelPhoto.AutoSize = true;
            this.LabelPhoto.BackColor = System.Drawing.Color.Transparent;
            this.LabelPhoto.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPhoto.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelPhoto.Location = new System.Drawing.Point(783, 31);
            this.LabelPhoto.Name = "LabelPhoto";
            this.LabelPhoto.Size = new System.Drawing.Size(73, 30);
            this.LabelPhoto.TabIndex = 31;
            this.LabelPhoto.Text = "头像";
            // 
            // ButtonUpdatePhoto
            // 
            this.ButtonUpdatePhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonUpdatePhoto.BackgroundImage")));
            this.ButtonUpdatePhoto.Location = new System.Drawing.Point(727, 335);
            this.ButtonUpdatePhoto.Name = "ButtonUpdatePhoto";
            this.ButtonUpdatePhoto.Size = new System.Drawing.Size(185, 36);
            this.ButtonUpdatePhoto.TabIndex = 32;
            this.ButtonUpdatePhoto.Text = "上传头像";
            this.ButtonUpdatePhoto.UseVisualStyleBackColor = true;
            this.ButtonUpdatePhoto.Click += new System.EventHandler(this.ButtonUpdatePhoto_Click);
            // 
            // LabelErrorPassword
            // 
            this.LabelErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorPassword.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelErrorPassword.Location = new System.Drawing.Point(424, 121);
            this.LabelErrorPassword.Name = "LabelErrorPassword";
            this.LabelErrorPassword.Size = new System.Drawing.Size(208, 30);
            this.LabelErrorPassword.TabIndex = 34;
            this.LabelErrorPassword.Text = "长度为6~20之间，只能由大小写字母、数字、下划线构成";
            this.LabelErrorPassword.Visible = false;
            // 
            // LabelErrorMailbox
            // 
            this.LabelErrorMailbox.AutoSize = true;
            this.LabelErrorMailbox.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorMailbox.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelErrorMailbox.Location = new System.Drawing.Point(424, 665);
            this.LabelErrorMailbox.Name = "LabelErrorMailbox";
            this.LabelErrorMailbox.Size = new System.Drawing.Size(97, 15);
            this.LabelErrorMailbox.TabIndex = 38;
            this.LabelErrorMailbox.Text = "邮件格式错误";
            this.LabelErrorMailbox.Visible = false;
            // 
            // LabelErrorEnsurepassword
            // 
            this.LabelErrorEnsurepassword.AutoSize = true;
            this.LabelErrorEnsurepassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorEnsurepassword.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelErrorEnsurepassword.Location = new System.Drawing.Point(424, 173);
            this.LabelErrorEnsurepassword.Name = "LabelErrorEnsurepassword";
            this.LabelErrorEnsurepassword.Size = new System.Drawing.Size(112, 15);
            this.LabelErrorEnsurepassword.TabIndex = 39;
            this.LabelErrorEnsurepassword.Text = "需要和密码相同";
            this.LabelErrorEnsurepassword.Visible = false;
            // 
            // LabelErrorAge
            // 
            this.LabelErrorAge.AutoSize = true;
            this.LabelErrorAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorAge.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelErrorAge.Location = new System.Drawing.Point(424, 371);
            this.LabelErrorAge.Name = "LabelErrorAge";
            this.LabelErrorAge.Size = new System.Drawing.Size(99, 15);
            this.LabelErrorAge.TabIndex = 42;
            this.LabelErrorAge.Text = "年龄范围0~99";
            this.LabelErrorAge.Visible = false;
            // 
            // LabelErrorIDNumber
            // 
            this.LabelErrorIDNumber.AutoSize = true;
            this.LabelErrorIDNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorIDNumber.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelErrorIDNumber.Location = new System.Drawing.Point(424, 418);
            this.LabelErrorIDNumber.Name = "LabelErrorIDNumber";
            this.LabelErrorIDNumber.Size = new System.Drawing.Size(127, 15);
            this.LabelErrorIDNumber.TabIndex = 43;
            this.LabelErrorIDNumber.Text = "身份证号格式错误";
            this.LabelErrorIDNumber.Visible = false;
            // 
            // LabelErrorMobileNumber
            // 
            this.LabelErrorMobileNumber.AutoSize = true;
            this.LabelErrorMobileNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorMobileNumber.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelErrorMobileNumber.Location = new System.Drawing.Point(424, 467);
            this.LabelErrorMobileNumber.Name = "LabelErrorMobileNumber";
            this.LabelErrorMobileNumber.Size = new System.Drawing.Size(112, 15);
            this.LabelErrorMobileNumber.TabIndex = 44;
            this.LabelErrorMobileNumber.Text = "手机号格式错误";
            this.LabelErrorMobileNumber.Visible = false;
            // 
            // LabelEmptyPhoto
            // 
            this.LabelEmptyPhoto.AutoSize = true;
            this.LabelEmptyPhoto.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyPhoto.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyPhoto.Location = new System.Drawing.Point(778, 394);
            this.LabelEmptyPhoto.Name = "LabelEmptyPhoto";
            this.LabelEmptyPhoto.Size = new System.Drawing.Size(82, 15);
            this.LabelEmptyPhoto.TabIndex = 45;
            this.LabelEmptyPhoto.Text = "请上传头像";
            // 
            // LabelEmptyName
            // 
            this.LabelEmptyName.AutoSize = true;
            this.LabelEmptyName.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyName.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyName.Location = new System.Drawing.Point(424, 282);
            this.LabelEmptyName.Name = "LabelEmptyName";
            this.LabelEmptyName.Size = new System.Drawing.Size(82, 15);
            this.LabelEmptyName.TabIndex = 46;
            this.LabelEmptyName.Text = "请输入姓名";
            // 
            // LabelEmptyAddress
            // 
            this.LabelEmptyAddress.AutoSize = true;
            this.LabelEmptyAddress.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyAddress.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyAddress.Location = new System.Drawing.Point(424, 620);
            this.LabelEmptyAddress.Name = "LabelEmptyAddress";
            this.LabelEmptyAddress.Size = new System.Drawing.Size(82, 15);
            this.LabelEmptyAddress.TabIndex = 47;
            this.LabelEmptyAddress.Text = "请输入地址";
            // 
            // LabelEmptyMailBox
            // 
            this.LabelEmptyMailBox.AutoSize = true;
            this.LabelEmptyMailBox.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyMailBox.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyMailBox.Location = new System.Drawing.Point(424, 665);
            this.LabelEmptyMailBox.Name = "LabelEmptyMailBox";
            this.LabelEmptyMailBox.Size = new System.Drawing.Size(82, 15);
            this.LabelEmptyMailBox.TabIndex = 48;
            this.LabelEmptyMailBox.Text = "请输入邮箱";
            // 
            // LabelEmptyWorkspace
            // 
            this.LabelEmptyWorkspace.AutoSize = true;
            this.LabelEmptyWorkspace.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyWorkspace.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyWorkspace.Location = new System.Drawing.Point(424, 565);
            this.LabelEmptyWorkspace.Name = "LabelEmptyWorkspace";
            this.LabelEmptyWorkspace.Size = new System.Drawing.Size(112, 15);
            this.LabelEmptyWorkspace.TabIndex = 49;
            this.LabelEmptyWorkspace.Text = "请输入工作单位";
            // 
            // LabelEmptyJob
            // 
            this.LabelEmptyJob.AutoSize = true;
            this.LabelEmptyJob.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyJob.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyJob.Location = new System.Drawing.Point(424, 518);
            this.LabelEmptyJob.Name = "LabelEmptyJob";
            this.LabelEmptyJob.Size = new System.Drawing.Size(82, 15);
            this.LabelEmptyJob.TabIndex = 50;
            this.LabelEmptyJob.Text = "请输入职业";
            // 
            // LabelEmptyMobilenumber
            // 
            this.LabelEmptyMobilenumber.AutoSize = true;
            this.LabelEmptyMobilenumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyMobilenumber.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyMobilenumber.Location = new System.Drawing.Point(424, 467);
            this.LabelEmptyMobilenumber.Name = "LabelEmptyMobilenumber";
            this.LabelEmptyMobilenumber.Size = new System.Drawing.Size(97, 15);
            this.LabelEmptyMobilenumber.TabIndex = 51;
            this.LabelEmptyMobilenumber.Text = "请输入手机号";
            // 
            // LabelEmptyIDNumber
            // 
            this.LabelEmptyIDNumber.AutoSize = true;
            this.LabelEmptyIDNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyIDNumber.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyIDNumber.Location = new System.Drawing.Point(424, 418);
            this.LabelEmptyIDNumber.Name = "LabelEmptyIDNumber";
            this.LabelEmptyIDNumber.Size = new System.Drawing.Size(112, 15);
            this.LabelEmptyIDNumber.TabIndex = 52;
            this.LabelEmptyIDNumber.Text = "请输入身份证号";
            // 
            // LabelEmptyNickname
            // 
            this.LabelEmptyNickname.AutoSize = true;
            this.LabelEmptyNickname.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyNickname.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyNickname.Location = new System.Drawing.Point(424, 75);
            this.LabelEmptyNickname.Name = "LabelEmptyNickname";
            this.LabelEmptyNickname.Size = new System.Drawing.Size(82, 15);
            this.LabelEmptyNickname.TabIndex = 53;
            this.LabelEmptyNickname.Text = "请输入昵称";
            // 
            // LabelEmptyPassword
            // 
            this.LabelEmptyPassword.AutoSize = true;
            this.LabelEmptyPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyPassword.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyPassword.Location = new System.Drawing.Point(424, 124);
            this.LabelEmptyPassword.Name = "LabelEmptyPassword";
            this.LabelEmptyPassword.Size = new System.Drawing.Size(82, 15);
            this.LabelEmptyPassword.TabIndex = 54;
            this.LabelEmptyPassword.Text = "请输入密码";
            // 
            // LabelEmptyEnsurepassword
            // 
            this.LabelEmptyEnsurepassword.AutoSize = true;
            this.LabelEmptyEnsurepassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyEnsurepassword.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyEnsurepassword.Location = new System.Drawing.Point(424, 173);
            this.LabelEmptyEnsurepassword.Name = "LabelEmptyEnsurepassword";
            this.LabelEmptyEnsurepassword.Size = new System.Drawing.Size(112, 15);
            this.LabelEmptyEnsurepassword.TabIndex = 55;
            this.LabelEmptyEnsurepassword.Text = "请再次输入密码";
            // 
            // LabelEmptyAge
            // 
            this.LabelEmptyAge.AutoSize = true;
            this.LabelEmptyAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmptyAge.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelEmptyAge.Location = new System.Drawing.Point(424, 371);
            this.LabelEmptyAge.Name = "LabelEmptyAge";
            this.LabelEmptyAge.Size = new System.Drawing.Size(82, 15);
            this.LabelEmptyAge.TabIndex = 56;
            this.LabelEmptyAge.Text = "请输入年龄";
            // 
            // LabelErrorNickname
            // 
            this.LabelErrorNickname.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorNickname.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelErrorNickname.Location = new System.Drawing.Point(424, 67);
            this.LabelErrorNickname.Name = "LabelErrorNickname";
            this.LabelErrorNickname.Size = new System.Drawing.Size(208, 30);
            this.LabelErrorNickname.TabIndex = 41;
            this.LabelErrorNickname.Text = "长度为3~20个之母，只能由汉字、数字、英文字母构成";
            this.LabelErrorNickname.Visible = false;
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.LabelEmptyAge);
            this.Controls.Add(this.LabelEmptyEnsurepassword);
            this.Controls.Add(this.LabelEmptyPassword);
            this.Controls.Add(this.LabelEmptyNickname);
            this.Controls.Add(this.LabelEmptyIDNumber);
            this.Controls.Add(this.LabelEmptyMobilenumber);
            this.Controls.Add(this.LabelEmptyJob);
            this.Controls.Add(this.LabelEmptyWorkspace);
            this.Controls.Add(this.LabelEmptyMailBox);
            this.Controls.Add(this.LabelEmptyAddress);
            this.Controls.Add(this.LabelEmptyName);
            this.Controls.Add(this.LabelEmptyPhoto);
            this.Controls.Add(this.LabelErrorMobileNumber);
            this.Controls.Add(this.LabelErrorIDNumber);
            this.Controls.Add(this.LabelErrorAge);
            this.Controls.Add(this.LabelErrorNickname);
            this.Controls.Add(this.LabelErrorEnsurepassword);
            this.Controls.Add(this.LabelErrorMailbox);
            this.Controls.Add(this.LabelErrorPassword);
            this.Controls.Add(this.ButtonUpdatePhoto);
            this.Controls.Add(this.LabelPhoto);
            this.Controls.Add(this.PictureBoxPhoto);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.PanelChooseSex);
            this.Controls.Add(this.TextBoxMailbox);
            this.Controls.Add(this.LabelMailbox);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.TextBoxWorkspace);
            this.Controls.Add(this.LabelWorkspace);
            this.Controls.Add(this.TextBoxJob);
            this.Controls.Add(this.LabelJob);
            this.Controls.Add(this.TextBoxMobilenumber);
            this.Controls.Add(this.LabelMobilenumber);
            this.Controls.Add(this.TextBoxIDNumber);
            this.Controls.Add(this.LabelIDNumber);
            this.Controls.Add(this.LabelBasicInformation);
            this.Controls.Add(this.LabelPersonalInformation);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.LableAge);
            this.Controls.Add(this.LabelSex);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelPersonalname);
            this.Controls.Add(this.TextBoxEnsurepassword);
            this.Controls.Add(this.LabelEnsurepassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxNickname);
            this.Controls.Add(this.LabelNickname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSignup";
            this.Text = "LWHY注册界面";
            this.PanelChooseSex.ResumeLayout(false);
            this.PanelChooseSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNickname;
        private System.Windows.Forms.TextBox TextBoxNickname;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxEnsurepassword;
        private System.Windows.Forms.Label LabelEnsurepassword;
        private System.Windows.Forms.Label LableAge;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelPersonalname;
        private System.Windows.Forms.Label LabelPersonalInformation;
        private System.Windows.Forms.Label LabelBasicInformation;
        private System.Windows.Forms.TextBox TextBoxJob;
        private System.Windows.Forms.Label LabelJob;
        private System.Windows.Forms.TextBox TextBoxMobilenumber;
        private System.Windows.Forms.Label LabelMobilenumber;
        private System.Windows.Forms.TextBox TextBoxIDNumber;
        private System.Windows.Forms.Label LabelIDNumber;
        private System.Windows.Forms.TextBox TextBoxMailbox;
        private System.Windows.Forms.Label LabelMailbox;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox TextBoxWorkspace;
        private System.Windows.Forms.Label LabelWorkspace;
        private System.Windows.Forms.RadioButton ButtonMale;
        private System.Windows.Forms.Panel PanelChooseSex;
        private System.Windows.Forms.RadioButton ButtonFemale;
        private System.Windows.Forms.TextBox TextBoxAge;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.PictureBox PictureBoxPhoto;
        private System.Windows.Forms.Label LabelPhoto;
        private System.Windows.Forms.Button ButtonUpdatePhoto;
        private System.Windows.Forms.Label LabelErrorPassword;
        private System.Windows.Forms.Label LabelErrorMailbox;
        private System.Windows.Forms.Label LabelErrorEnsurepassword;
        private System.Windows.Forms.Label LabelErrorAge;
        private System.Windows.Forms.Label LabelErrorIDNumber;
        private System.Windows.Forms.Label LabelErrorMobileNumber;
        private System.Windows.Forms.Label LabelEmptyPhoto;
        private System.Windows.Forms.Label LabelEmptyName;
        private System.Windows.Forms.Label LabelEmptyAddress;
        private System.Windows.Forms.Label LabelEmptyMailBox;
        private System.Windows.Forms.Label LabelEmptyWorkspace;
        private System.Windows.Forms.Label LabelEmptyJob;
        private System.Windows.Forms.Label LabelEmptyMobilenumber;
        private System.Windows.Forms.Label LabelEmptyIDNumber;
        private System.Windows.Forms.Label LabelEmptyNickname;
        private System.Windows.Forms.Label LabelEmptyPassword;
        private System.Windows.Forms.Label LabelEmptyEnsurepassword;
        private System.Windows.Forms.Label LabelEmptyAge;
        private System.Windows.Forms.Label LabelErrorNickname;
    }
}

