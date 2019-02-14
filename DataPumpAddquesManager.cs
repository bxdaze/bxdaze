using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using RecordQuestion;

namespace LWHY
{
    class DataPumpAddquesManager : IDataPumpAddquesManager
    {
        
        bool IDataPumpAddquesManager.AddNewquestion(Question _que, Classification where)//添加一个新题gie!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            OracleConnection conn = new OracleConnection();
            bool success = false;
            try
            {
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();
                Console.Write("Success open \n ");

                String sql = "insert into TEMPQUESTION(ttitle,tbody,tanswer,tstatue,ttype)values(:ttitle,:tbody,:tanswer,:tstatue,:ttype)";

               OracleCommand cmd = new OracleCommand(sql, conn);

                OracleParameter pari = new OracleParameter(":ttitle", _que.title);
               OracleParameter parn = new OracleParameter(":tbody", _que.body);
                OracleParameter parp = new OracleParameter(":answer", _que.answer);
                OracleParameter pars = new OracleParameter(":tstatue", 'n');
                OracleParameter party = new OracleParameter(":ttype", _que.type);
                
                cmd.Parameters.Add(pari);
                cmd.Parameters.Add(parn);
                cmd.Parameters.Add(parp);
                cmd.Parameters.Add(pars);
                cmd.Parameters.Add(party);
                int result = cmd.ExecuteNonQuery();
                if (result != 1)
                {
                    throw new Exception("写入tempquesion失败");

                }
                Console.Write("success for temp" + result);

                int temp_tqid = 0;
                String gettqid = "select tqid from TEMPQUESTION where tqid in (select max(tqid) as tqid from TEMPQUESTION)";
                OracleCommand cmd1 = new OracleCommand(gettqid, conn);
                OracleDataReader dr1 = cmd1.ExecuteReader(); // C#  

                if (dr1.HasRows)
                {


                    while (dr1.Read())
                    {
                        temp_tqid = (int)dr1["tqid"];
                    }
                }
                else
                {
                    throw new Exception("未能读取到相应的tqid");
                }
                Console.Write(temp_tqid);

                String getcid = "select cid from CLASSFICATION where TOPCLASSFICATION ='"+where.Cla[0]+"' and SECONDCLASSFICATION='"+where.Cla[1]+"'";
                OracleCommand cmd2 = new OracleCommand(getcid, conn);
                OracleDataReader dr2 = cmd2.ExecuteReader(); // C#  
                int temp_cid = 0;
                if (dr2.HasRows)
                {


                    while (dr2.Read())
                    {
                        temp_cid = (int)dr2["cid"];
                    }
                }
                else
                {
                    throw new Exception("未能读取到相应的cid");
                }


                if (temp_cid != 0)
                {
                    String ISql = "insert into TCLASSIFICATIONMAP(tqid,cid) values(:tqid,:cid)";
                    OracleCommand cmd3 = new OracleCommand(ISql, conn);
                    OracleParameter tqidpar = new OracleParameter(":tqid", temp_tqid);
                    OracleParameter cidpar = new OracleParameter(":cid", temp_cid);
                    cmd3.Parameters.Add(tqidpar);
                    cmd3.Parameters.Add(cidpar);
                    int result2 = cmd3.ExecuteNonQuery();
                    if (result2 != 1)
                    {
                        throw new Exception("写入tempquesion失败");

                    }
                    Console.Write("success for temp" + result2);
                }
                else
                {
                    throw new Exception("没有这个分类");
                }


                ManagerAssign ma = new ManagerAssign();
                int temp_managerid = ma.giveAssign(temp_tqid, 'a');
                if (temp_managerid != 0)
                {
                    success = true;
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

            return success;
        }


        
        List<Classification> SetOfClassification()
        {
            OracleConnection conn = new OracleConnection();
            List<Classification> temp_lCla=new List<Classification>();
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from CLASSIFICATION";

                OracleCommand cmd = new OracleCommand(sql, conn);


                OracleDataReader dr = cmd.ExecuteReader(); // C#  
                if (dr.HasRows)
                {


                    while (dr.Read())
                    {
                        Classification temp_cla = new Classification();
                        temp_cla.cId = (int)dr[""];
                        temp_cla.Cla[0] = dr[""].ToString();
                        temp_cla.Cla[1] = dr[""].ToString();
                        temp_cla.Cla[2] = dr[""].ToString();
                        temp_cla.Cla[3] = dr[""].ToString();
                        temp_cla.Cla[4] = dr[""].ToString();
                        temp_lCla.Add(temp_cla);
                       
                    }
                }
                else
                {
                    throw new Exception("未能读取到相应的问题");
                }





            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Clone();
            }
            return temp_lCla;
        }
    
        
    
    }
}
