using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LWHY

{
    class DataPumdUserfeedback : IDataPumdUserfeedback
    {
        OracleConnection conn = new OracleConnection();
        void IDataPumdUserfeedback.write(FeedBack tmp, int UserID)
        {
             try
            {
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();
                Console.Write("Success open \n ");



                String sql = "insert into FEEDBACK(classification,brief,description)values(:classification,:brief,:description)";

                OracleCommand cmd = new OracleCommand(sql, conn);

                OracleParameter pari = new OracleParameter(":classification", tmp.classfication);
                OracleParameter parn = new OracleParameter(":brief", tmp.brief);
                OracleParameter parp = new OracleParameter(":description", tmp.description);
              
                
                cmd.Parameters.Add(pari);
                cmd.Parameters.Add(parn);
                cmd.Parameters.Add(parp);
               
                int result = cmd.ExecuteNonQuery();
                if (result != 1)
                {
                    throw new Exception("写入user失败");
                }
                Console.Write("success for feedback" + result);


                String gettqid = "select fid from FEEDBACK where fid in (select max(fid) as fid from FEEDBACK)";
                OracleCommand cmd1 = new OracleCommand(gettqid, conn);
                OracleDataReader dr1 = cmd1.ExecuteReader(); // C#  
                int temp_fid=0;
                if (dr1.HasRows)
                {


                    while (dr1.Read())
                    {
                        temp_fid = (int)dr1["fid"];
                    }
                }
                else
                {
                    throw new Exception("未能读取到相应的tqid");
                }

                String sqlmap = "insert into FEEDBACKMAP(userid,fid)values(:userid,:fid)";

                OracleCommand cmdmap = new OracleCommand(sqlmap, conn);

                OracleParameter parimap = new OracleParameter(":userid", UserID);
                OracleParameter parnmap = new OracleParameter(":fid", temp_fid);
               

                cmdmap.Parameters.Add(parimap);
                cmdmap.Parameters.Add(parnmap);
               

                int resultmap = cmdmap.ExecuteNonQuery();
                if (resultmap != 1)
                {
                    throw new Exception("写入user失败");
                }
                Console.Write("success for feedbackmap" + result);



                int temp_manaegerId = 0;
                String getmid = "SELECT * from MANAGERJOBLIST";
                OracleCommand cmdx = new OracleCommand(getmid, conn);
                OracleDataReader drx = cmdx.ExecuteReader(); // C#  

                if (drx.HasRows)
                {
                    int min = 999999999;

                    while (drx.Read())
                    {
                        int temp_num = int.Parse(drx["mnum"].ToString());
                        if (temp_num <= min)
                        {
                            min = temp_num;
                            temp_manaegerId = (int)drx["managerid"];
                        }


                    }
                }
                else
                {
                    throw new Exception("未能读取到相应的mqid");
                }

                if (temp_manaegerId != 0)
                {
                    String ISql = "insert into HANDLE(managerid,fid,ishandled) values(:managerid,:fid,:ishandled)";
                    OracleCommand cmd3 = new OracleCommand(ISql, conn);
                    OracleParameter midpar = new OracleParameter(":managerid", temp_manaegerId);
                    OracleParameter typepar = new OracleParameter(":fid", temp_fid);
                    OracleParameter stapar = new OracleParameter(":ishandled", 'n');
                    //OracleParameter dealpar = new OracleParameter(":dealid", _qid);

                    cmd3.Parameters.Add(midpar);
                    cmd3.Parameters.Add(typepar);
                    cmd3.Parameters.Add(stapar);
                   // cmd3.Parameters.Add(dealpar);
                    int result2 = cmd3.ExecuteNonQuery();
                    if (result2 != 1)
                    {
                        throw new Exception("写入handle失败");

                    }
                    Console.Write("success for temp" + result2);
                }
                else
                {
                    throw new Exception("没查到managerid");
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
