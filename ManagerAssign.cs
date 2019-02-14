using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LWHY
{
    class ManagerAssign
    {
       OracleConnection conn = new OracleConnection();
        public int giveAssign(int _qid, char _type)
       {
            int temp_manaegerId = 0;
           try
           {
               
               conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
               conn.Open();
               Console.Write("Success open \n ");


               String getmid = "SELECT * from MANAGERJOBLIST";
               OracleCommand cmd1 = new OracleCommand(getmid, conn);
               OracleDataReader dr1 = cmd1.ExecuteReader(); // C#  

               if (dr1.HasRows)
               {
                   int min = 999999999;

                   while (dr1.Read())
                   {
                       int temp_num = int.Parse(dr1["mnum"].ToString());
                       if(temp_num<=min)
                       {
                           min = temp_num;
                           temp_manaegerId = (int)dr1["managerid"];
                       }
                    
                       
                   }
               }
               else
               {
                   throw new Exception("未能读取到相应的mqid");
               }

               if (temp_manaegerId != 0)
               {
                   String ISql = "insert into EXAMINE(managerid,etype,estatue,dealid) values(:managerid,:etype,:estatue,:dealid)";
                   OracleCommand cmd3 = new OracleCommand(ISql, conn);
                   OracleParameter midpar = new OracleParameter(":managerid", temp_manaegerId);
                   OracleParameter typepar = new OracleParameter(":etype", _type);
                   OracleParameter stapar = new OracleParameter(":estatue", 'n');
                   OracleParameter dealpar = new OracleParameter(":dealid", _qid);

                   cmd3.Parameters.Add(midpar);
                   cmd3.Parameters.Add(typepar);
                   cmd3.Parameters.Add(stapar);
                   cmd3.Parameters.Add(dealpar);
                   int result2 = cmd3.ExecuteNonQuery();
                   if (result2 != 1)
                   {
                       throw new Exception("写入tempquesion失败");

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
            return temp_manaegerId;
        }
    }
}
