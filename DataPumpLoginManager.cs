using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using LWHY;

namespace WindowsFormsApp_login
{
    class DataPump_Login : IDataPump_Login
    {
        OracleConnection conn = new OracleConnection();
        User IDataPump_Login.isAlive(string tb_User)
        {
            User temp_user = null;
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();
               
                string sql = " select * from IUSER where unickname = "+"\'"+tb_User+"\'"; // C#  
                
                OracleCommand cmd = new OracleCommand(sql, conn);


                OracleDataReader dr = cmd.ExecuteReader(); // C#  
                if (dr.HasRows)
                {
                    
                    temp_user = new User();
                    while (dr.Read())
                    {
                        temp_user.userid = (int) dr["userid"];
                        temp_user.nickname = dr["unickname"].ToString();
                        temp_user.password = dr["upassword"].ToString();
                        
                        if(dr["ustatue"].ToString()=="o")
                        {
                            temp_user.isOnline = true;
                        }
                        else if (dr["ustatue"].ToString() == "f")
                        {
                            temp_user.isOnline = false;
                        }
                        else
                        {
                            throw new Exception();
                        }
                        

                    }
                }
                Console.Write(temp_user.nickname);
               
               


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Clone();
            }
            return temp_user;
           
        }
    }
}
