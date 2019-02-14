using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWHY;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsUser
{
    class DataPump_UserManage : IDataPumpUserManage
    {
        
        Information IDataPumpUserManage.getUserInfo(int userID)
        {
            OracleConnection conn = new OracleConnection();
            Information ifo = new Information();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from INFORMATION where iid="+userID; // C#  
                Console.Write(sql);
                OracleCommand cmd = new OracleCommand(sql, conn);


                OracleDataReader dr = cmd.ExecuteReader(); // C#  
                if (dr.HasRows)
                {


                    while (dr.Read())
                    {
                        ifo.id=(int)dr["iid"];
                        ifo.name = dr["iname"].ToString();
                        ifo.idcardnum = dr["idcardnum"].ToString();
                        ifo.phonenum = dr["phonenum"].ToString();
                        ifo.address = dr["address"].ToString();
                        ifo.sex=dr["sex"].ToString()[0];
                        ifo.age=(int)dr["age"];
                        ifo.email=dr["email"].ToString();
                     }
                }
                else
                {
                    throw new Exception("未能读取到相应的信息");
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
            return ifo;
        }

        List<Question> IDataPumpUserManage.getCollectQuestion(int userID)
        {
            OracleConnection conn = new OracleConnection();
            List<Question> temp_lQuestion = new List<Question>();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from QUESTION where qid in （select qid from QUESTIONMAP where userid = " +userID+ " and iscollected = 'y')"; // C#  
                Console.Write(sql);
                OracleCommand cmd = new OracleCommand(sql, conn);


                OracleDataReader dr = cmd.ExecuteReader(); // C#  
                if (dr.HasRows)
                {


                    while (dr.Read())
                    {
                        Question temp_question = new Question();
                        temp_question.questionId = (int)dr["qid"];
                        temp_question.title = dr["title"].ToString();
                        temp_question.body = dr["body"].ToString();
                        temp_question.answer = dr["answer"].ToString();
                        temp_question.tags = dr["tags"].ToString();
                        String str = dr["type"].ToString();//这句之后要进行思考。
                        temp_question.type = str[0];
                        temp_lQuestion.Add(temp_question);
                        Console.Write(temp_question.title);
                    }
                }
                else
                {
                    throw new Exception("未能读取到相应的问题");
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

            return temp_lQuestion;
        }
    }
}
