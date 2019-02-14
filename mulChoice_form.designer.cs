namespace RecordQuestion
{
    partial class mulChoice_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Chocie_finish = new System.Windows.Forms.Button();
            this.Choice_Show = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(142, 119);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Title.Size = new System.Drawing.Size(287, 97);
            this.Title.TabIndex = 0;
            this.Title.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(73, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入选择题题目";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(140, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "点此添加选项";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 0;
            this.textBox2.Tag = "";
            // 
            // Chocie_finish
            // 
            this.Chocie_finish.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Chocie_finish.Location = new System.Drawing.Point(255, 478);
            this.Chocie_finish.Name = "Chocie_finish";
            this.Chocie_finish.Size = new System.Drawing.Size(117, 38);
            this.Chocie_finish.TabIndex = 3;
            this.Chocie_finish.Text = "确认提交";
            this.Chocie_finish.UseVisualStyleBackColor = true;
            this.Chocie_finish.Visible = false;
            this.Chocie_finish.Click += new System.EventHandler(this.Chocie_finish_Click);
            // 
            // Choice_Show
            // 
            this.Choice_Show.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Choice_Show.Location = new System.Drawing.Point(561, 47);
            this.Choice_Show.Multiline = true;
            this.Choice_Show.Name = "Choice_Show";
            this.Choice_Show.ReadOnly = true;
            this.Choice_Show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Choice_Show.Size = new System.Drawing.Size(188, 250);
            this.Choice_Show.TabIndex = 4;
            this.Choice_Show.Visible = false;
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Answer.Location = new System.Drawing.Point(285, 430);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(35, 28);
            this.Answer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(131, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "答案（大写）";
            // 
            // mulChoice_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Choice_Show);
            this.Controls.Add(this.Chocie_finish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "mulChoice_form";
            this.Text = "开始录题";
            this.Load += new System.EventHandler(this.multipleChoice_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Chocie_finish;
        private System.Windows.Forms.TextBox Choice_Show;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label label2;
    }
}