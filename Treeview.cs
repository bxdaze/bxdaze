using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Treeview : Form
    {
        List<string> exp;
        public Treeview()
        {
            InitializeComponent();
        }



        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)//生成一个list<string> 存有门类字符串,Messagebox用于测试
        {
                if (this.treeView1.SelectedNode.Nodes.Count == 0)
                {
                    exp = new List<string>();
                    TreeNode temp = this.treeView1.SelectedNode.Parent;
                    exp.Insert(0, this.treeView1.SelectedNode.Text);

                    while (temp != null)
                    {
                        exp.Insert(0, temp.Text);
                        temp = temp.Parent;
                    }
                    string show = "";
                    foreach (string x in exp)
                    {
                        show += (x+" ");
                    }
                    MessageBox.Show(show);
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
