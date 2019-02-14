namespace LWHY_Search
{
    partial class problem
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
            this.button1 = new System.Windows.Forms.Button();
            this.m_btnShowAns = new System.Windows.Forms.Button();
            this.m_lbTitle = new System.Windows.Forms.Label();
            this.m_lbBody = new System.Windows.Forms.Label();
            this.m_lbAns = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "收藏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_btnShowAns
            // 
            this.m_btnShowAns.Location = new System.Drawing.Point(305, 414);
            this.m_btnShowAns.Name = "m_btnShowAns";
            this.m_btnShowAns.Size = new System.Drawing.Size(94, 29);
            this.m_btnShowAns.TabIndex = 5;
            this.m_btnShowAns.Text = "显示答案";
            this.m_btnShowAns.UseVisualStyleBackColor = true;
            this.m_btnShowAns.Click += new System.EventHandler(this.m_btnShowAns_Click);
            // 
            // m_lbTitle
            // 
            this.m_lbTitle.AutoSize = true;
            this.m_lbTitle.Location = new System.Drawing.Point(4, 0);
            this.m_lbTitle.Name = "m_lbTitle";
            this.m_lbTitle.Size = new System.Drawing.Size(41, 12);
            this.m_lbTitle.TabIndex = 6;
            this.m_lbTitle.Text = "label1";
            // 
            // m_lbBody
            // 
            this.m_lbBody.AutoSize = true;
            this.m_lbBody.Location = new System.Drawing.Point(4, 0);
            this.m_lbBody.Name = "m_lbBody";
            this.m_lbBody.Size = new System.Drawing.Size(41, 12);
            this.m_lbBody.TabIndex = 7;
            this.m_lbBody.Text = "label2";
            // 
            // m_lbAns
            // 
            this.m_lbAns.AutoSize = true;
            this.m_lbAns.Location = new System.Drawing.Point(4, 0);
            this.m_lbAns.Name = "m_lbAns";
            this.m_lbAns.Size = new System.Drawing.Size(41, 12);
            this.m_lbAns.TabIndex = 8;
            this.m_lbAns.Text = "label3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_lbAns);
            this.splitContainer1.Size = new System.Drawing.Size(482, 398);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(0, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.m_lbTitle);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.m_lbBody);
            this.splitContainer2.Size = new System.Drawing.Size(478, 283);
            this.splitContainer2.SplitterDistance = 143;
            this.splitContainer2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "添加标签";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.m_btnShowAns);
            this.Controls.Add(this.button1);
            this.Name = "problem";
            this.Text = "Problem";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button m_btnShowAns;
        private System.Windows.Forms.Label m_lbTitle;
        private System.Windows.Forms.Label m_lbBody;
        private System.Windows.Forms.Label m_lbAns;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button2;
    }
}