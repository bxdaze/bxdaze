namespace WindowsFormsUser
{
    partial class ShowMyQuestionForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userFrameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userFrameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFrameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFrameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.tagsDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(745, 626);
            this.dataGridView1.TabIndex = 0;
            // 
            // userFrameBindingSource
            // 
            this.userFrameBindingSource.DataSource = typeof(WindowsFormsUser.UserFrame);
            // 
            // userFrameBindingSource1
            // 
            this.userFrameBindingSource1.DataSource = typeof(WindowsFormsUser.UserFrame);
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(LWHY.Question);
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            this.questionIdDataGridViewTextBoxColumn.DataPropertyName = "questionId";
            this.questionIdDataGridViewTextBoxColumn.HeaderText = "questionId";
            this.questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            this.questionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "body";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "answer";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagsDataGridViewTextBoxColumn
            // 
            this.tagsDataGridViewTextBoxColumn.DataPropertyName = "tags";
            this.tagsDataGridViewTextBoxColumn.HeaderText = "tags";
            this.tagsDataGridViewTextBoxColumn.Name = "tagsDataGridViewTextBoxColumn";
            this.tagsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ShowMyQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 626);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowMyQuestionForm";
            this.Text = "ShowMyQuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFrameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFrameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userFrameBindingSource;
        private System.Windows.Forms.BindingSource userFrameBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questionBindingSource;
    }
}