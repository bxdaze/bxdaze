namespace WindowsFormsApp_login
{
    partial class FLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.tB_User = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            this.cB_Password = new System.Windows.Forms.CheckBox();
            this.b_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(287, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录界面";
            // 
            // tB_User
            // 
            this.tB_User.Location = new System.Drawing.Point(249, 248);
            this.tB_User.Margin = new System.Windows.Forms.Padding(4);
            this.tB_User.Name = "tB_User";
            this.tB_User.Size = new System.Drawing.Size(301, 26);
            this.tB_User.TabIndex = 1;
            this.tB_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_KeyPress);
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(249, 367);
            this.tB_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(301, 26);
            this.tB_Password.TabIndex = 2;
            this.tB_Password.TextChanged += new System.EventHandler(this.tB_Password_TextChanged);
            this.tB_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(132, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(132, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(249, 499);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(301, 37);
            this.b_ok.TabIndex = 5;
            this.b_ok.Text = "确定";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // cB_Password
            // 
            this.cB_Password.AutoSize = true;
            this.cB_Password.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cB_Password.Location = new System.Drawing.Point(249, 441);
            this.cB_Password.Name = "cB_Password";
            this.cB_Password.Size = new System.Drawing.Size(108, 24);
            this.cB_Password.TabIndex = 6;
            this.cB_Password.Text = "显示密码";
            this.cB_Password.UseVisualStyleBackColor = true;
            this.cB_Password.CheckedChanged += new System.EventHandler(this.cB_Password_CheckedChanged);
            // 
            // b_Register
            // 
            this.b_Register.Location = new System.Drawing.Point(249, 561);
            this.b_Register.Name = "b_Register";
            this.b_Register.Size = new System.Drawing.Size(301, 36);
            this.b_Register.TabIndex = 7;
            this.b_Register.Text = "注册";
            this.b_Register.UseVisualStyleBackColor = true;
            this.b_Register.Click += new System.EventHandler(this.b_Register_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Register);
            this.Controls.Add(this.cB_Password);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_User);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_User;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.CheckBox cB_Password;
        private System.Windows.Forms.Button b_Register;
    }
}

