using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LWHY;

namespace WindowsFormsUser
{
    public partial class ShowMyQuestionForm : Form
    {
        public ShowMyQuestionForm()
        {
            InitializeComponent();
            UserManage temp_um = new UserManage(new LWHY.User(3, "litong", "123456", true));
            this.dataGridView1.DataSource = new List<Question>();
            this.dataGridView1.DataSource = temp_um.cQuestion;
        } 
    }
}
