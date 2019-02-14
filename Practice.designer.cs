namespace LWHY_test
{
    partial class Practice
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_tvSubStru = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.m_lbTitle = new System.Windows.Forms.Label();
            this.m_lbBody = new System.Windows.Forms.Label();
            this.m_tbAns = new System.Windows.Forms.TextBox();
            this.m_btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.m_tvSubStru);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.m_btnSubmit);
            this.splitContainer1.Size = new System.Drawing.Size(613, 481);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 0;
            // 
            // m_tvSubStru
            // 
            this.m_tvSubStru.Location = new System.Drawing.Point(3, 3);
            this.m_tvSubStru.Name = "m_tvSubStru";
            this.m_tvSubStru.Size = new System.Drawing.Size(197, 475);
            this.m_tvSubStru.TabIndex = 0;
            this.m_tvSubStru.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.m_tvSubStru_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(4, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.m_tbAns);
            this.splitContainer2.Size = new System.Drawing.Size(392, 427);
            this.splitContainer2.SplitterDistance = 294;
            this.splitContainer2.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.m_lbTitle);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.m_lbBody);
            this.splitContainer3.Size = new System.Drawing.Size(392, 294);
            this.splitContainer3.SplitterDistance = 130;
            this.splitContainer3.TabIndex = 0;
            // 
            // m_lbTitle
            // 
            this.m_lbTitle.AutoSize = true;
            this.m_lbTitle.Location = new System.Drawing.Point(3, 0);
            this.m_lbTitle.Name = "m_lbTitle";
            this.m_lbTitle.Size = new System.Drawing.Size(41, 12);
            this.m_lbTitle.TabIndex = 7;
            this.m_lbTitle.Text = "label1";
            // 
            // m_lbBody
            // 
            this.m_lbBody.AutoSize = true;
            this.m_lbBody.Location = new System.Drawing.Point(3, 0);
            this.m_lbBody.Name = "m_lbBody";
            this.m_lbBody.Size = new System.Drawing.Size(41, 12);
            this.m_lbBody.TabIndex = 8;
            this.m_lbBody.Text = "label2";
            // 
            // m_tbAns
            // 
            this.m_tbAns.Location = new System.Drawing.Point(1, 2);
            this.m_tbAns.Multiline = true;
            this.m_tbAns.Name = "m_tbAns";
            this.m_tbAns.Size = new System.Drawing.Size(388, 126);
            this.m_tbAns.TabIndex = 0;
            // 
            // m_btnSubmit
            // 
            this.m_btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_btnSubmit.Location = new System.Drawing.Point(309, 440);
            this.m_btnSubmit.Name = "m_btnSubmit";
            this.m_btnSubmit.Size = new System.Drawing.Size(85, 38);
            this.m_btnSubmit.TabIndex = 4;
            this.m_btnSubmit.Text = "提交";
            this.m_btnSubmit.UseVisualStyleBackColor = true;
            this.m_btnSubmit.Click += new System.EventHandler(this.m_btnSubmit_Click);
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 481);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Practice";
            this.Text = "Practice";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button m_btnSubmit;
        private System.Windows.Forms.TreeView m_tvSubStru;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label m_lbTitle;
        private System.Windows.Forms.Label m_lbBody;
        private System.Windows.Forms.TextBox m_tbAns;
    }
}