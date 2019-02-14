namespace LWHY_test
{
    partial class Modelchose
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
            this.m_btnStart = new System.Windows.Forms.Button();
            this.m_rbExam = new System.Windows.Forms.RadioButton();
            this.m_rbPractice = new System.Windows.Forms.RadioButton();
            this.m_splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_cbShortAns = new System.Windows.Forms.CheckBox();
            this.m_cbGapFilling = new System.Windows.Forms.CheckBox();
            this.m_cbCalc = new System.Windows.Forms.CheckBox();
            this.m_cbTOF = new System.Windows.Forms.CheckBox();
            this.m_cbChoice = new System.Windows.Forms.CheckBox();
            this.m_tvSubStru = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainer)).BeginInit();
            this.m_splitContainer.Panel1.SuspendLayout();
            this.m_splitContainer.Panel2.SuspendLayout();
            this.m_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnStart
            // 
            this.m_btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_btnStart.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnStart.Location = new System.Drawing.Point(268, 379);
            this.m_btnStart.Name = "m_btnStart";
            this.m_btnStart.Size = new System.Drawing.Size(117, 36);
            this.m_btnStart.TabIndex = 0;
            this.m_btnStart.Text = "开始";
            this.m_btnStart.UseVisualStyleBackColor = true;
            this.m_btnStart.Click += new System.EventHandler(this.m_btnStart_Click);
            // 
            // m_rbExam
            // 
            this.m_rbExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_rbExam.AutoSize = true;
            this.m_rbExam.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_rbExam.Location = new System.Drawing.Point(8, 11);
            this.m_rbExam.Name = "m_rbExam";
            this.m_rbExam.Size = new System.Drawing.Size(103, 23);
            this.m_rbExam.TabIndex = 1;
            this.m_rbExam.TabStop = true;
            this.m_rbExam.Text = "考试模式";
            this.m_rbExam.UseVisualStyleBackColor = true;
            // 
            // m_rbPractice
            // 
            this.m_rbPractice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_rbPractice.AutoSize = true;
            this.m_rbPractice.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_rbPractice.Location = new System.Drawing.Point(8, 40);
            this.m_rbPractice.Name = "m_rbPractice";
            this.m_rbPractice.Size = new System.Drawing.Size(103, 23);
            this.m_rbPractice.TabIndex = 2;
            this.m_rbPractice.TabStop = true;
            this.m_rbPractice.Text = "练习模式";
            this.m_rbPractice.UseVisualStyleBackColor = true;
            // 
            // m_splitContainer
            // 
            this.m_splitContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_splitContainer.Location = new System.Drawing.Point(4, 1);
            this.m_splitContainer.Name = "m_splitContainer";
            // 
            // m_splitContainer.Panel1
            // 
            this.m_splitContainer.Panel1.Controls.Add(this.m_rbPractice);
            this.m_splitContainer.Panel1.Controls.Add(this.m_rbExam);
            // 
            // m_splitContainer.Panel2
            // 
            this.m_splitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.m_splitContainer.Panel2.Controls.Add(this.m_btnStart);
            this.m_splitContainer.Size = new System.Drawing.Size(599, 430);
            this.m_splitContainer.SplitterDistance = 199;
            this.m_splitContainer.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-1, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.m_cbShortAns);
            this.splitContainer1.Panel1.Controls.Add(this.m_cbGapFilling);
            this.splitContainer1.Panel1.Controls.Add(this.m_cbCalc);
            this.splitContainer1.Panel1.Controls.Add(this.m_cbTOF);
            this.splitContainer1.Panel1.Controls.Add(this.m_cbChoice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_tvSubStru);
            this.splitContainer1.Size = new System.Drawing.Size(394, 370);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 1;
            // 
            // m_cbShortAns
            // 
            this.m_cbShortAns.AutoSize = true;
            this.m_cbShortAns.Location = new System.Drawing.Point(157, 52);
            this.m_cbShortAns.Name = "m_cbShortAns";
            this.m_cbShortAns.Size = new System.Drawing.Size(60, 16);
            this.m_cbShortAns.TabIndex = 4;
            this.m_cbShortAns.Text = "简答题";
            this.m_cbShortAns.UseVisualStyleBackColor = true;
            // 
            // m_cbGapFilling
            // 
            this.m_cbGapFilling.AutoSize = true;
            this.m_cbGapFilling.Location = new System.Drawing.Point(157, 11);
            this.m_cbGapFilling.Name = "m_cbGapFilling";
            this.m_cbGapFilling.Size = new System.Drawing.Size(60, 16);
            this.m_cbGapFilling.TabIndex = 3;
            this.m_cbGapFilling.Text = "填空题";
            this.m_cbGapFilling.UseVisualStyleBackColor = true;
            // 
            // m_cbCalc
            // 
            this.m_cbCalc.AutoSize = true;
            this.m_cbCalc.Location = new System.Drawing.Point(5, 52);
            this.m_cbCalc.Name = "m_cbCalc";
            this.m_cbCalc.Size = new System.Drawing.Size(60, 16);
            this.m_cbCalc.TabIndex = 2;
            this.m_cbCalc.Text = "计算题";
            this.m_cbCalc.UseVisualStyleBackColor = true;
            // 
            // m_cbTOF
            // 
            this.m_cbTOF.AutoSize = true;
            this.m_cbTOF.Location = new System.Drawing.Point(308, 11);
            this.m_cbTOF.Name = "m_cbTOF";
            this.m_cbTOF.Size = new System.Drawing.Size(60, 16);
            this.m_cbTOF.TabIndex = 1;
            this.m_cbTOF.Text = "判断题";
            this.m_cbTOF.UseVisualStyleBackColor = true;
            // 
            // m_cbChoice
            // 
            this.m_cbChoice.AutoSize = true;
            this.m_cbChoice.Location = new System.Drawing.Point(5, 11);
            this.m_cbChoice.Name = "m_cbChoice";
            this.m_cbChoice.Size = new System.Drawing.Size(60, 16);
            this.m_cbChoice.TabIndex = 0;
            this.m_cbChoice.Text = "选择题";
            this.m_cbChoice.UseVisualStyleBackColor = true;
            // 
            // m_tvSubStru
            // 
            this.m_tvSubStru.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_tvSubStru.Location = new System.Drawing.Point(3, 3);
            this.m_tvSubStru.Name = "m_tvSubStru";
            this.m_tvSubStru.Size = new System.Drawing.Size(394, 281);
            this.m_tvSubStru.TabIndex = 0;
            this.m_tvSubStru.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.m_tvSubStru_AfterSelect);
            // 
            // Modelchose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 428);
            this.Controls.Add(this.m_splitContainer);
            this.Name = "Modelchose";
            this.Text = "题目与模式选择";
            this.m_splitContainer.Panel1.ResumeLayout(false);
            this.m_splitContainer.Panel1.PerformLayout();
            this.m_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainer)).EndInit();
            this.m_splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);


            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modelchose_FormClosing);

        }

        #endregion

        private System.Windows.Forms.Button m_btnStart;
        private System.Windows.Forms.RadioButton m_rbExam;
        private System.Windows.Forms.RadioButton m_rbPractice;
        private System.Windows.Forms.SplitContainer m_splitContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView m_tvSubStru;
        private System.Windows.Forms.CheckBox m_cbShortAns;
        private System.Windows.Forms.CheckBox m_cbGapFilling;
        private System.Windows.Forms.CheckBox m_cbCalc;
        private System.Windows.Forms.CheckBox m_cbTOF;
        private System.Windows.Forms.CheckBox m_cbChoice;

       
    }
}

