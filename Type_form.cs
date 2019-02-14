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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace RecordQuestion
{
    public partial class Type_form : MyForm
    {


         List<Classification> Atong;

        List<string> Classi;//分类
        bool classbj;//判断是否选择分类
        Classification where;
        char QuestionType = 'f';

        public Type_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!classbj)
            {
                MessageBox.Show("请选择分类！！！");
                return;
            }
            if(QuestionType == 'f')
            {
                MessageBox.Show("请选择题型！！！");
                return;
            }

            where = new Classification(0, getClass());//传递分类实例



            switch (QuestionType)
                            {
                                        case 'a':
                                          {
                                               mulChoice_form fs = new mulChoice_form();
                                                fs.Show();
                                                fs.SetWhere(where);
                                                

                    }
                    break;

                                        case 'b':
                                            {
                        Judge fs = new Judge();
                        fs.Show();
                        fs.SetWhere(where);
                    }
                    break;

                                        case 'c':
                                            {
                        Caculation fs = new Caculation();
                        fs.Show();
                        fs.SetWhere(where);
                    }
                    break;
                                        case 'd':
                                            {
                        SAnswer fs = new SAnswer();
                        fs.Show();
                        fs.SetWhere(where);
                    }
                    break;
                                        case 'e':
                                            {
                                                Blank fs = new Blank();
                                                fs.Show();
                                                fs.SetWhere(where);
                    }
                                            break;

                default:
                                            {
                        MessageBox.Show("选项选择出现错误！！！");
                        Application.Exit();
                    }
                    break;
                            }



        }

   



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


     
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeView1.SelectedNode.Nodes.Count == 0)
            {
                Classi = new List<string>();
                TreeNode temp = this.treeView1.SelectedNode.Parent;
                Classi.Insert(0, this.treeView1.SelectedNode.Text);

                while (temp != null)
                {
                    Classi.Insert(0, temp.Text);
                    temp = temp.Parent;
                }


                /* string show = "";
                 foreach (string x in Classi)
                 {
                     show += (x + " ");
                 }
                 MessageBox.Show(show);*/

                classbj = true;
            }
        }

        string[] getClass()
        {
            return Classi.ToArray();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            QuestionType = 'a';//题类型为选择题
        }

        private void blank_CheckedChanged(object sender, EventArgs e)
        {
            QuestionType = 'e';//题类型为填空题
        }

        private void sanswer_CheckedChanged(object sender, EventArgs e)
        {
            QuestionType = 'd';//题类型为简答题
        }

        private void dudge_CheckedChanged(object sender, EventArgs e)
        {
            QuestionType = 'b';//题类型为判断题
        }

        private void calcu_CheckedChanged(object sender, EventArgs e)
        {
            QuestionType = 'c';//题类型为计算题
        }

        public List<Classification>  getTest()
        {

            List<Classification> Atong = new List<Classification>();
            foreach (TreeNode n in treeView1.Nodes)
            {
                
                foreach (TreeNode m in n.Nodes)
                {
                    List<string> post = new List<string>();
                    TreeNode temp = m.Parent;
                        post.Insert(0, m.Text);

                        while (temp != null)
                        {
                            post.Insert(0, temp.Text);
                            temp = temp.Parent;
                        }

                        Atong.Add(new Classification(0, post.ToArray()));
                        
                        /*string show = "";
                        foreach (string x in post)
                        {
                            show += (x + " ");
                        }
                    MessageBox.Show(show);*/


                }        
            }
            return Atong;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            OracleConnection conn = new OracleConnection();
            Atong = getTest();
             try
            {
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();
                Console.Write("Success open \n ");
                 foreach (Classification cla in Atong)
                 {
                     String sql = "insert into CLASSFICATION(topclassfication,secondclassfication)values(:topclassfication,:secondclassfication)";

                     OracleCommand cmd = new OracleCommand(sql, conn);

                    OracleParameter pari = new OracleParameter(":topclassfication", cla.Cla[0]);
                    OracleParameter parn = new OracleParameter(":secondclassfication", cla.Cla[1]);
                

                     cmd.Parameters.Add(pari);
                     cmd.Parameters.Add(parn);
                
                     int result = cmd.ExecuteNonQuery();
                      if (result != 1)
                    {
                        throw new Exception("写入tempquesion失败");
   
                       }
                     Console.Write("success for temp" + result);
                    }

            }
             catch (Exception ex)
             {
                 Console.Write(ex.Message);
             }
             finally
             {
                 conn.Clone();
             }
             */
           
        }
        private void Type_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
         }
    }
}
