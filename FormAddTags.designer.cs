namespace AddTagsForm
{
    partial class FormAddTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTags));
            this.LabelAddTags = new System.Windows.Forms.Label();
            this.TextBoxAddTags = new System.Windows.Forms.TextBox();
            this.LabelTagsRule = new System.Windows.Forms.Label();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.LabelQuestionID = new System.Windows.Forms.Label();
            this.LabelQuestionTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAddTags
            // 
            this.LabelAddTags.AutoSize = true;
            this.LabelAddTags.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddTags.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelAddTags.Location = new System.Drawing.Point(38, 98);
            this.LabelAddTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAddTags.Name = "LabelAddTags";
            this.LabelAddTags.Size = new System.Drawing.Size(250, 24);
            this.LabelAddTags.TabIndex = 0;
            this.LabelAddTags.Text = "请添加你想添加的标签";
            // 
            // TextBoxAddTags
            // 
            this.TextBoxAddTags.BackColor = System.Drawing.Color.LightGreen;
            this.TextBoxAddTags.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TextBoxAddTags.Location = new System.Drawing.Point(42, 150);
            this.TextBoxAddTags.Name = "TextBoxAddTags";
            this.TextBoxAddTags.Size = new System.Drawing.Size(433, 34);
            this.TextBoxAddTags.TabIndex = 1;
            // 
            // LabelTagsRule
            // 
            this.LabelTagsRule.AutoSize = true;
            this.LabelTagsRule.BackColor = System.Drawing.Color.Transparent;
            this.LabelTagsRule.ForeColor = System.Drawing.Color.Yellow;
            this.LabelTagsRule.Location = new System.Drawing.Point(38, 209);
            this.LabelTagsRule.Name = "LabelTagsRule";
            this.LabelTagsRule.Size = new System.Drawing.Size(358, 24);
            this.LabelTagsRule.TabIndex = 2;
            this.LabelTagsRule.Tag = "";
            this.LabelTagsRule.Text = "标签应简明扼要，长度为3~6个字";
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEnter.BackgroundImage")));
            this.ButtonEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEnter.Location = new System.Drawing.Point(501, 197);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(169, 46);
            this.ButtonEnter.TabIndex = 3;
            this.ButtonEnter.Text = "确定";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // LabelQuestionID
            // 
            this.LabelQuestionID.AutoSize = true;
            this.LabelQuestionID.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuestionID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelQuestionID.Location = new System.Drawing.Point(38, 31);
            this.LabelQuestionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuestionID.Name = "LabelQuestionID";
            this.LabelQuestionID.Size = new System.Drawing.Size(250, 24);
            this.LabelQuestionID.TabIndex = 4;
            this.LabelQuestionID.Text = "请添加你想添加的标签";
            // 
            // LabelQuestionTitle
            // 
            this.LabelQuestionTitle.AutoSize = true;
            this.LabelQuestionTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuestionTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelQuestionTitle.Location = new System.Drawing.Point(322, 31);
            this.LabelQuestionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuestionTitle.Name = "LabelQuestionTitle";
            this.LabelQuestionTitle.Size = new System.Drawing.Size(250, 24);
            this.LabelQuestionTitle.TabIndex = 5;
            this.LabelQuestionTitle.Text = "请添加你想添加的标签";
            // 
            // FormAddTags
            // 
            this.AcceptButton = this.ButtonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 255);
            this.Controls.Add(this.LabelQuestionTitle);
            this.Controls.Add(this.LabelQuestionID);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.LabelTagsRule);
            this.Controls.Add(this.TextBoxAddTags);
            this.Controls.Add(this.LabelAddTags);
            this.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddTags";
            this.Text = "添加标签";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddTags;
        private System.Windows.Forms.TextBox TextBoxAddTags;
        private System.Windows.Forms.Label LabelTagsRule;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Label LabelQuestionID;
        private System.Windows.Forms.Label LabelQuestionTitle;
    }
}

