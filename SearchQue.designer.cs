namespace LWHY_Search
{
    partial class SearchQue
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
            this.m_tbQue = new System.Windows.Forms.TextBox();
            this.m_btnSearch = new System.Windows.Forms.Button();
            this.m_gbSearch = new System.Windows.Forms.GroupBox();
            this.m_rbTitleSearch = new System.Windows.Forms.RadioButton();
            this.m_rbTagSearch = new System.Windows.Forms.RadioButton();
            this.m_rbClaSearch = new System.Windows.Forms.RadioButton();
            this.m_lbTitle = new System.Windows.Forms.Label();
            this.m_gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tbQue
            // 
            this.m_tbQue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_tbQue.Location = new System.Drawing.Point(120, 88);
            this.m_tbQue.Name = "m_tbQue";
            this.m_tbQue.Size = new System.Drawing.Size(267, 21);
            this.m_tbQue.TabIndex = 0;
            // 
            // m_btnSearch
            // 
            this.m_btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_btnSearch.Location = new System.Drawing.Point(412, 88);
            this.m_btnSearch.Name = "m_btnSearch";
            this.m_btnSearch.Size = new System.Drawing.Size(91, 21);
            this.m_btnSearch.TabIndex = 1;
            this.m_btnSearch.Text = "搜索";
            this.m_btnSearch.UseVisualStyleBackColor = true;
            this.m_btnSearch.Click += new System.EventHandler(this.m_btnSearch_Click);
            // 
            // m_gbSearch
            // 
            this.m_gbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_gbSearch.Controls.Add(this.m_rbTitleSearch);
            this.m_gbSearch.Controls.Add(this.m_rbTagSearch);
            this.m_gbSearch.Controls.Add(this.m_rbClaSearch);
            this.m_gbSearch.Location = new System.Drawing.Point(120, 115);
            this.m_gbSearch.Name = "m_gbSearch";
            this.m_gbSearch.Size = new System.Drawing.Size(267, 39);
            this.m_gbSearch.TabIndex = 2;
            this.m_gbSearch.TabStop = false;
            // 
            // m_rbTitleSearch
            // 
            this.m_rbTitleSearch.AutoSize = true;
            this.m_rbTitleSearch.Location = new System.Drawing.Point(156, 9);
            this.m_rbTitleSearch.Name = "m_rbTitleSearch";
            this.m_rbTitleSearch.Size = new System.Drawing.Size(71, 16);
            this.m_rbTitleSearch.TabIndex = 2;
            this.m_rbTitleSearch.TabStop = true;
            this.m_rbTitleSearch.Text = "标题搜索";
            this.m_rbTitleSearch.UseVisualStyleBackColor = true;
            // 
            // m_rbTagSearch
            // 
            this.m_rbTagSearch.AutoSize = true;
            this.m_rbTagSearch.Location = new System.Drawing.Point(84, 9);
            this.m_rbTagSearch.Name = "m_rbTagSearch";
            this.m_rbTagSearch.Size = new System.Drawing.Size(65, 16);
            this.m_rbTagSearch.TabIndex = 1;
            this.m_rbTagSearch.TabStop = true;
            this.m_rbTagSearch.Text = "Tag搜索";
            this.m_rbTagSearch.UseVisualStyleBackColor = true;
            // 
            // m_rbClaSearch
            // 
            this.m_rbClaSearch.AutoSize = true;
            this.m_rbClaSearch.Location = new System.Drawing.Point(7, 9);
            this.m_rbClaSearch.Name = "m_rbClaSearch";
            this.m_rbClaSearch.Size = new System.Drawing.Size(71, 16);
            this.m_rbClaSearch.TabIndex = 0;
            this.m_rbClaSearch.TabStop = true;
            this.m_rbClaSearch.Text = "分类搜索";
            this.m_rbClaSearch.UseVisualStyleBackColor = true;
            // 
            // m_lbTitle
            // 
            this.m_lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_lbTitle.AutoSize = true;
            this.m_lbTitle.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbTitle.Location = new System.Drawing.Point(185, 32);
            this.m_lbTitle.Name = "m_lbTitle";
            this.m_lbTitle.Size = new System.Drawing.Size(147, 33);
            this.m_lbTitle.TabIndex = 3;
            this.m_lbTitle.Text = "题库搜索";
            // 
            // SearchQue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 355);
            this.Controls.Add(this.m_lbTitle);
            this.Controls.Add(this.m_gbSearch);
            this.Controls.Add(this.m_btnSearch);
            this.Controls.Add(this.m_tbQue);
            this.MaximumSize = new System.Drawing.Size(619, 393);
            this.MinimumSize = new System.Drawing.Size(619, 393);
            this.Name = "SearchQue";
            this.Text = "题库搜索";
            this.m_gbSearch.ResumeLayout(false);
            this.m_gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQue_FormClosing);

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbQue;
        private System.Windows.Forms.Button m_btnSearch;
        private System.Windows.Forms.GroupBox m_gbSearch;
        private System.Windows.Forms.RadioButton m_rbTitleSearch;
        private System.Windows.Forms.RadioButton m_rbTagSearch;
        private System.Windows.Forms.RadioButton m_rbClaSearch;
        private System.Windows.Forms.Label m_lbTitle;
    }
}

