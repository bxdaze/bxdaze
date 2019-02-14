namespace RecordQuestion
{
    partial class Caculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Chocie_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入计算题题目";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(124, 103);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Title.Size = new System.Drawing.Size(338, 83);
            this.Title.TabIndex = 2;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(124, 289);
            this.Answer.Multiline = true;
            this.Answer.Name = "Answer";
            this.Answer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Answer.Size = new System.Drawing.Size(338, 69);
            this.Answer.TabIndex = 5;
            this.Answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Answer_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "答案及解析";
            // 
            // Chocie_finish
            // 
            this.Chocie_finish.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Chocie_finish.Location = new System.Drawing.Point(254, 413);
            this.Chocie_finish.Name = "Chocie_finish";
            this.Chocie_finish.Size = new System.Drawing.Size(117, 38);
            this.Chocie_finish.TabIndex = 7;
            this.Chocie_finish.Text = "确认提交";
            this.Chocie_finish.UseVisualStyleBackColor = true;
            this.Chocie_finish.Visible = false;
            this.Chocie_finish.Click += new System.EventHandler(this.Chocie_finish_Click);
            // 
            // Caculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 502);
            this.Controls.Add(this.Chocie_finish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Name = "Caculation";
            this.Text = "开始录题";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Chocie_finish;
    }
}