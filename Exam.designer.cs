namespace LWHY_test
{
    partial class Exam
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.m_tbMin = new System.Windows.Forms.TextBox();
            this.m_tbSec = new System.Windows.Forms.TextBox();
            this.m_btnTimeStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tbHour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.m_tbAns = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.m_lbTitle = new System.Windows.Forms.Label();
            this.m_lbBody = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(610, 437);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.button1);
            this.splitContainer4.Panel1.Controls.Add(this.m_tbMin);
            this.splitContainer4.Panel1.Controls.Add(this.m_tbSec);
            this.splitContainer4.Panel1.Controls.Add(this.m_btnTimeStart);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            this.splitContainer4.Panel1.Controls.Add(this.m_tbHour);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.treeView1);
            this.splitContainer4.Size = new System.Drawing.Size(201, 437);
            this.splitContainer4.SplitterDistance = 100;
            this.splitContainer4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "结束考试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_tbMin
            // 
            this.m_tbMin.Location = new System.Drawing.Point(76, 3);
            this.m_tbMin.Name = "m_tbMin";
            this.m_tbMin.Size = new System.Drawing.Size(47, 21);
            this.m_tbMin.TabIndex = 4;
            // 
            // m_tbSec
            // 
            this.m_tbSec.Location = new System.Drawing.Point(150, 3);
            this.m_tbSec.Name = "m_tbSec";
            this.m_tbSec.Size = new System.Drawing.Size(38, 21);
            this.m_tbSec.TabIndex = 5;
            // 
            // m_btnTimeStart
            // 
            this.m_btnTimeStart.Location = new System.Drawing.Point(12, 65);
            this.m_btnTimeStart.Name = "m_btnTimeStart";
            this.m_btnTimeStart.Size = new System.Drawing.Size(67, 33);
            this.m_btnTimeStart.TabIndex = 0;
            this.m_btnTimeStart.Text = "开始考试";
            this.m_btnTimeStart.UseVisualStyleBackColor = true;
            this.m_btnTimeStart.Click += new System.EventHandler(this.m_btnTimeStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "：";
            // 
            // m_tbHour
            // 
            this.m_tbHour.Location = new System.Drawing.Point(10, 3);
            this.m_tbHour.Name = "m_tbHour";
            this.m_tbHour.Size = new System.Drawing.Size(38, 21);
            this.m_tbHour.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(129, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "：";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(201, 333);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer2.Size = new System.Drawing.Size(403, 437);
            this.splitContainer2.SplitterDistance = 323;
            this.splitContainer2.TabIndex = 0;
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
            this.splitContainer3.Size = new System.Drawing.Size(403, 323);
            this.splitContainer3.SplitterDistance = 107;
            this.splitContainer3.TabIndex = 0;
            // 
            // m_tbAns
            // 
            this.m_tbAns.Location = new System.Drawing.Point(0, 1);
            this.m_tbAns.Multiline = true;
            this.m_tbAns.Name = "m_tbAns";
            this.m_tbAns.Size = new System.Drawing.Size(403, 109);
            this.m_tbAns.TabIndex = 0;
            this.m_tbAns.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // m_lbTitle
            // 
            this.m_lbTitle.AutoSize = true;
            this.m_lbTitle.Location = new System.Drawing.Point(0, 0);
            this.m_lbTitle.Name = "m_lbTitle";
            this.m_lbTitle.Size = new System.Drawing.Size(41, 12);
            this.m_lbTitle.TabIndex = 8;
            this.m_lbTitle.Text = "label1";
            // 
            // m_lbBody
            // 
            this.m_lbBody.AutoSize = true;
            this.m_lbBody.Location = new System.Drawing.Point(0, 0);
            this.m_lbBody.Name = "m_lbBody";
            this.m_lbBody.Size = new System.Drawing.Size(41, 12);
            this.m_lbBody.TabIndex = 9;
            this.m_lbBody.Text = "label2";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 437);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Exam";
            this.Text = "Exam";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button m_btnTimeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_tbHour;
        private System.Windows.Forms.TextBox m_tbMin;
        private System.Windows.Forms.TextBox m_tbSec;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox m_tbAns;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label m_lbTitle;
        private System.Windows.Forms.Label m_lbBody;
    }
}