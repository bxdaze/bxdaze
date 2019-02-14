using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LWHY
{
   public class DataPumpSearchQueManager : IDataPumpSearchQueManager
    {
        
        List<Question> IDataPumpSearchQueManager.SetOfSubQuestion(int Cla)//指示课程分类的那个String数组类 ques存储cla这个分类下所有题目
        {
            OracleConnection conn = new OracleConnection();
            List<Question> temp_lQuestion = new List<Question>();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from QUESTION where qid in （select qid from CLASSFICATIONMAP where cid = " +  Cla +")" ; // C#  
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



        List<Question> IDataPumpSearchQueManager.SetOfClaQuestion(char Cla)//ques存储所有Cla类型的题目（选择 判断 这种）
        {
            OracleConnection conn = new OracleConnection();
           
            List<Question> temp_lQuestion = new List<Question>();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from QUESTION where type = " +"\'"+ Cla + "\'"; // C#  

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
                        temp_question.type = dr["type"].ToString()[0];//这句之后要进行思考。
                        temp_lQuestion.Add(temp_question);
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


        Question IDataPumpSearchQueManager.FindOneQuestion(int qId)//参数为问题的编码（key），返回该问题所有内容
        {
            OracleConnection conn = new OracleConnection();
            Question temp_que = new Question();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from QUESTION where qid = " + qId; // C#  

                OracleCommand cmd = new OracleCommand(sql, conn);


                OracleDataReader dr = cmd.ExecuteReader(); // C#  
                if (dr.HasRows)
                {


                    while (dr.Read())
                    {

                        temp_que.questionId = (int)dr["qid"];
                        temp_que.title = dr["title"].ToString();
                        temp_que.body = dr["body"].ToString();
                        temp_que.answer = dr["answer"].ToString();
                        temp_que.tags = dr["tags"].ToString();
                        temp_que.type = dr["type"].ToString()[0];//这句之后要进行思考。
                        
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


            return temp_que;
        }
        List<Question> IDataPumpSearchQueManager.QuestionTitleSearch(String title)//给出标题关键词，返回包含该关键词的所有问题
        {
            OracleConnection conn = new OracleConnection();
            List<Question> temp_lQuestion = new List<Question>();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from QUESTION where title like '%" +title + "%'"; // C#  !!!!!!!!!!!!!!!!!!!!!!!
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
                        temp_question.type = dr["type"].ToString()[0];//这句之后要进行思考。
                        temp_lQuestion.Add(temp_question);
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
        List<Question> IDataPumpSearchQueManager.QuestionTagSearch(String tag)//给出tag关键词，返回包含该关键词的所有问题
        {
            OracleConnection conn = new OracleConnection();
            List<Question> temp_lQuestion = new List<Question>();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from QUESTION where qid in (select qid from TAGSMAP natural join TAGS where tname like '%" + tag + "%' )"; // C#  !!!!!!!!!!!!!!!!!!!!!!!

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
                        temp_question.type = dr["type"].ToString()[0];//这句之后要进行思考。
                        temp_lQuestion.Add(temp_question);
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
        List<Question> IDataPumpSearchQueManager.QuestionClaSearch(String cla)//给出分类关键词，返回包含该关键词的所有问题,!!!!!!!!!!!!!!!!!!!!11
        {
            OracleConnection conn = new OracleConnection();
            List<Question> temp_lQuestion = new List<Question>();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = "select * from QUESTION where qid in (select qid from CLASSFICATIONMAP natural join CLASSFICATION where TOPCLASSFICATION LIKE '%" + cla + "%' OR SECONDCLASSFICATION like '%" + cla + "%' OR THIRDCLASSFICATION like '%" + cla + "%' OR FORTHCLASSFICATION like '%" + cla + "%' OR FIFTHCLASSFICATION like '%" + cla + "%')"; // C#  !!!!!!!!!!!!!!!!!!!!!!!

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
                        temp_question.type = dr["type"].ToString()[0];//这句之后要进行思考。
                        temp_lQuestion.Add(temp_question);
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
        List<Classification> IDataPumpSearchQueManager.SetOfClassification()
        {
            OracleConnection conn = new OracleConnection();
            List<Classification> ClaSet = new List<Classification>();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = "select * from CLASSFICATION ";// C#  !!!!!!!!!!!!!!!!!!!!!!!

                OracleCommand cmd = new OracleCommand(sql, conn);


                OracleDataReader dr = cmd.ExecuteReader(); // C#  
                if (dr.HasRows)
                {


                    while (dr.Read())
                    {
                        Classification temp_Classification = new Classification();
                        temp_Classification.cId = (int)dr["cid"];
                        temp_Classification.Cla[0] = dr["topclassfication"].ToString();
                        temp_Classification.Cla[1] = dr["secondclassfication"].ToString();//这句之后要进行思考。
                        ClaSet.Add(temp_Classification);
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
            return ClaSet;
        }

        void IDataPumpSearchQueManager.addcllection(int qid, int userid)
        {
            OracleConnection conn = new OracleConnection();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = "insert into QUESTIONMAP (qid,userid,iscollected) values(:qid,:userid,:iscllocted) ";// C#  !!!!!!!!!!!!!!!!!!!!!!!

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleParameter Ipari = new OracleParameter(":qid", qid);

                OracleParameter Iparn = new OracleParameter(":userid", userid);

                OracleParameter Iparc = new OracleParameter(":iscllocted",'y');
                cmd.Parameters.Add(Ipari);
                cmd.Parameters.Add(Iparn);
                cmd.Parameters.Add(Iparc);
                int result2 = cmd.ExecuteNonQuery();
                if (result2 != 1)
                {
                    throw new Exception("写入cllocted失败");
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



        }
    }
}
