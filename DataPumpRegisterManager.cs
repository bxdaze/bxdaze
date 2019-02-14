using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LWHY
{
    public class DataPumpRegisterManager:IDataPumpRegisterManager
    {
        
        bool IDataPumpRegisterManager.checkName(string _name)
        {
            OracleConnection conn = new OracleConnection();
            bool temp_isExist = false;
            try
            {
                
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select * from IUSER where unickname = " + "\'" + _name + "\'"; // C#  

                OracleCommand cmd = new OracleCommand(sql, conn);


                OracleDataReader dr = cmd.ExecuteReader(); // C#  
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        String temp_nickname=dr["unickname"].ToString();
                        if (temp_nickname == _name)
                        {
                            temp_isExist = true;
                        }
                        else
                        {
                            throw new Exception("未知错误，代号DPRM");
                        }
                    }

                }
                else
                {
                    temp_isExist = false;

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Clone();
            }
            return temp_isExist;

        }//用户名是否存在
        void IDataPumpRegisterManager.updateRegisterInformation(User _userinformation, Information _registerinformation)
        {
            OracleConnection conn = new OracleConnection();
            try
            {


                
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();
                Console.Write("Success open \n ");

                
                String sql = "insert into IUSER(unickname,upassword,ustatue)values(:unickname,:upassword,:ustatue)";

                OracleCommand cmd = new OracleCommand(sql, conn);

                //OracleParameter pari = new OracleParameter(":userid", _userinformation.userid);
                OracleParameter parn = new OracleParameter(":unickname", _userinformation.nickname);
                OracleParameter parp = new OracleParameter(":upassword", _userinformation.password);
                OracleParameter pars;
                if (_userinformation.isOnline)
                {
                    throw new Exception("未知错误，错误代码DPRM");
                }
                else
                {
                     pars = new OracleParameter(":ustatue", 'f');
                }
               // cmd.Parameters.Add(pari);
                cmd.Parameters.Add(parn);
                cmd.Parameters.Add(parp);
                cmd.Parameters.Add(pars);
                int result = cmd.ExecuteNonQuery();
                if(result!=1)
                {
                    throw new Exception("写入user失败");
                }
                Console.Write("success for user"+result);


                int temp_uid = 0;
                String getuid = "select userid from IUSER where userid in (select max(userid) as userid from IUSER)";
                OracleCommand cmd1 = new OracleCommand(getuid, conn);
                OracleDataReader dr1 = cmd1.ExecuteReader(); // C#  

                if (dr1.HasRows)
                {


                    while (dr1.Read())
                    {
                        temp_uid = (int)dr1["userid"];
                    }
                }
                else
                {
                    throw new Exception("未能读取到相应的userid");
                }





                String Isql = "insert into INFORMATION(iid,iname,idcardnum,phonenum,address,sex,age,email,role,photo)values(:iid,:iname,:idcardnum,:phonenum,:address,:sex,:age,:email,:role,EMPTY_BLOB())";

                OracleCommand Icmd = new OracleCommand(Isql, conn);

                OracleParameter Ipari = new OracleParameter("iid", temp_uid);
               
                OracleParameter Iparn = new OracleParameter("iname", _registerinformation.name);
                
                OracleParameter Iparc = new OracleParameter("idcardnum", _registerinformation.idcardnum);
               
                OracleParameter Iparpn = new OracleParameter("phonenum", _registerinformation.phonenum);
                
                OracleParameter Iparad = new OracleParameter("address", _registerinformation.address);
              
                OracleParameter Ipars = new OracleParameter("sex", _registerinformation.sex);
                
                OracleParameter Iparag = new OracleParameter("age", _registerinformation.age);


                
               // Console.Write("success for photo"+by.Length);
                OracleParameter Ipare = new OracleParameter("email", _registerinformation.email);
                
                OracleParameter Iparr = new OracleParameter("role", _registerinformation.role);
                
                
                Icmd.Parameters.Add(Ipari);
                Icmd.Parameters.Add(Iparn);
                Icmd.Parameters.Add(Iparc);
                Icmd.Parameters.Add(Iparpn);
                Icmd.Parameters.Add(Iparad);
                Icmd.Parameters.Add(Ipars);
                Icmd.Parameters.Add(Iparag);
               // Icmd.Parameters.Add(Iparnpo);
                Icmd.Parameters.Add(Ipare);
                Icmd.Parameters.Add(Iparr);
              
                int result2 = Icmd.ExecuteNonQuery();
                if(result2!=1)
                {
                    throw new Exception("写入information失败");
                }
                 
                Console.Write("success for information");

                
     /*
                byte[] by = ImageHelper.ImageToBytes(_registerinformation.photo);
                
                String photosql = "select * from INFORMATION where iid =" + 4 ;
                OracleTransaction trans = conn.BeginTransaction();//interlize a trans
                OracleCommand photocmd = new OracleCommand(photosql,conn);
                OracleDataReader pdr = cmd.ExecuteReader();
                pdr.Read();
                OracleBlob lob = pdr.GetOracleBlob(9);
                bool xx = lob.CanWrite;
                lob.Write(by,0,by.Length);
                trans.Commit();
      */
                 
               /* String photosql = "update INFORMATION set photo = :photo where iid = 20";
                OracleCommand photocmd = new OracleCommand(photosql, conn);
                OracleParameter pparr = new OracleParameter(":photo", by);
                photocmd.Parameters.Add(pparr);
                int result22 = Icmd.ExecuteNonQuery();
                Console.Write(result22);
*/

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                conn.Clone();
            }
 
        }//插入用户信息。


       
    }
}
