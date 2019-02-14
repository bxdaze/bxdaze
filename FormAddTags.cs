using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using RegisterAndTagsAdd;
using LWHY;

namespace AddTagsForm
{
    public partial class FormAddTags : Form
    {
        IDataPumpAddTags IDPAT = new DataPumpAddTags();
        Question theQue = new Question();
        public FormAddTags(Question que)
        {
            theQue = que;
            //string temp_questionID = "000";
            //string temp_questiontitle = "一道不存在的题";
            //AddTagsManager.getQuestionInformation(temp_questionID, temp_questiontitle);
            InitializeComponent();
            this.LabelQuestionID.Text = que.questionId.ToString();
            this.LabelQuestionTitle.Text = que.title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            Regex temp_tagsjudge = new Regex("^[\u4E00-\u9FA5]{3,6}$");
            if (!temp_tagsjudge.IsMatch(TextBoxAddTags.Text)) {
                MessageBoxButtons temp_OKButton = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("标签不符合格式", "返回", temp_OKButton);
                if (dr == DialogResult.OK);
            }
            else
            {
                IDPAT.addTagsRank(TextBoxAddTags.Text,theQue.questionId);
                MessageBoxButtons temp_OKButton = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("标签添加成功", "返回", temp_OKButton);
                if (dr == DialogResult.OK)
                {  
                    this.Hide();
                    this.Owner.ShowDialog();
                    
                }
            }
        }

    }
}
