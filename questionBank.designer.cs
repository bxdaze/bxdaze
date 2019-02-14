namespace LWHY_Search
{
    partial class questionBank
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
            this.m_llPrevious = new System.Windows.Forms.LinkLabel();
            this.m_llNext = new System.Windows.Forms.LinkLabel();
            this.m_llEnd = new System.Windows.Forms.LinkLabel();
            this.m_llTop = new System.Windows.Forms.LinkLabel();
            this.m_tbPages = new System.Windows.Forms.TextBox();
            this.m_btnGoto = new System.Windows.Forms.Button();
            this.m_lbNow = new System.Windows.Forms.Label();
            this.m_dgvQueBank = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvQueBank)).BeginInit();
            this.SuspendLayout();
            // 
            // m_llPrevious
            // 
            this.m_llPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_llPrevious.AutoSize = true;
            this.m_llPrevious.Location = new System.Drawing.Point(499, 397);
            this.m_llPrevious.Name = "m_llPrevious";
            this.m_llPrevious.Size = new System.Drawing.Size(41, 12);
            this.m_llPrevious.TabIndex = 0;
            this.m_llPrevious.TabStop = true;
            this.m_llPrevious.Text = "上一页";
            this.m_llPrevious.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.m_llPrevious_LinkClicked);
            // 
            // m_llNext
            // 
            this.m_llNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_llNext.AutoSize = true;
            this.m_llNext.Location = new System.Drawing.Point(546, 397);
            this.m_llNext.Name = "m_llNext";
            this.m_llNext.Size = new System.Drawing.Size(41, 12);
            this.m_llNext.TabIndex = 1;
            this.m_llNext.TabStop = true;
            this.m_llNext.Text = "下一页";
            this.m_llNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.m_llNext_LinkClicked);
            // 
            // m_llEnd
            // 
            this.m_llEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_llEnd.AutoSize = true;
            this.m_llEnd.Location = new System.Drawing.Point(593, 397);
            this.m_llEnd.Name = "m_llEnd";
            this.m_llEnd.Size = new System.Drawing.Size(29, 12);
            this.m_llEnd.TabIndex = 2;
            this.m_llEnd.TabStop = true;
            this.m_llEnd.Text = "尾页";
            this.m_llEnd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.m_llEnd_LinkClicked);
            // 
            // m_llTop
            // 
            this.m_llTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_llTop.AutoSize = true;
            this.m_llTop.Location = new System.Drawing.Point(464, 397);
            this.m_llTop.Name = "m_llTop";
            this.m_llTop.Size = new System.Drawing.Size(29, 12);
            this.m_llTop.TabIndex = 3;
            this.m_llTop.TabStop = true;
            this.m_llTop.Text = "首页";
            this.m_llTop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.m_llTop_LinkClicked);
            // 
            // m_tbPages
            // 
            this.m_tbPages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_tbPages.ForeColor = System.Drawing.Color.Gray;
            this.m_tbPages.Location = new System.Drawing.Point(495, 362);
            this.m_tbPages.Name = "m_tbPages";
            this.m_tbPages.Size = new System.Drawing.Size(67, 21);
            this.m_tbPages.TabIndex = 4;
            this.m_tbPages.TextChanged += new System.EventHandler(this.m_tbPages_TextChanged);
            // 
            // m_btnGoto
            // 
            this.m_btnGoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_btnGoto.Location = new System.Drawing.Point(577, 362);
            this.m_btnGoto.Name = "m_btnGoto";
            this.m_btnGoto.Size = new System.Drawing.Size(45, 20);
            this.m_btnGoto.TabIndex = 5;
            this.m_btnGoto.Text = "跳转";
            this.m_btnGoto.UseVisualStyleBackColor = true;
            this.m_btnGoto.Click += new System.EventHandler(this.m_btnGoto_Click);
            // 
            // m_lbNow
            // 
            this.m_lbNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_lbNow.AutoSize = true;
            this.m_lbNow.Location = new System.Drawing.Point(418, 365);
            this.m_lbNow.Name = "m_lbNow";
            this.m_lbNow.Size = new System.Drawing.Size(71, 12);
            this.m_lbNow.TabIndex = 6;
            this.m_lbNow.Text = "第 1 页   -";
            // 
            // m_dgvQueBank
            // 
            this.m_dgvQueBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvQueBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3});
            this.m_dgvQueBank.Location = new System.Drawing.Point(-2, 3);
            this.m_dgvQueBank.Name = "m_dgvQueBank";
            this.m_dgvQueBank.RowTemplate.Height = 23;
            this.m_dgvQueBank.Size = new System.Drawing.Size(638, 359);
            this.m_dgvQueBank.TabIndex = 7;
            this.m_dgvQueBank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_dgvQueBank_CellContentClick);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "完成情况";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "题号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "标题";
            this.Column2.Name = "Column2";
            this.Column2.Width = 245;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tag";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // questionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 415);
            this.Controls.Add(this.m_dgvQueBank);
            this.Controls.Add(this.m_lbNow);
            this.Controls.Add(this.m_btnGoto);
            this.Controls.Add(this.m_tbPages);
            this.Controls.Add(this.m_llTop);
            this.Controls.Add(this.m_llEnd);
            this.Controls.Add(this.m_llNext);
            this.Controls.Add(this.m_llPrevious);
            this.Name = "questionBank";
            this.Text = "questionBank";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvQueBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel m_llPrevious;
        private System.Windows.Forms.LinkLabel m_llNext;
        private System.Windows.Forms.LinkLabel m_llEnd;
        private System.Windows.Forms.LinkLabel m_llTop;
        private System.Windows.Forms.TextBox m_tbPages;
        private System.Windows.Forms.Button m_btnGoto;
        private System.Windows.Forms.Label m_lbNow;
        private System.Windows.Forms.DataGridView m_dgvQueBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}