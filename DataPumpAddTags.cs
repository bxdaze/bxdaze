using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace RegisterAndTagsAdd
{
    class DataPumpAddTags : IDataPumpAddTags
    {
        void IDataPumpAddTags.addTagsRank(string _tags,int qid)
        {
            OracleConnection conn = new OracleConnection();
           
            try
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["oradb"].ConnectionString;  
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=59.110.237.142)(PORT=1521)))(CONNECT_DATA=(sid =lwhy)));User Id=lwhy;Password=123";
                conn.Open();

                string sql = " select tid from  TAGS where tname= '"+_tags+"'"; // C#  
                
                OracleCommand cmd = new OracleCommand(sql, conn);


                OracleDataReader dr = cmd.ExecuteReader(); // C#  
                int  temp_tid = 0;
                if (dr.HasRows)
                {
                    temp_tid = (int)dr["tid"];   
                 }
                else
                {
                    String addtags = "insert into TAGS(tname) values(:tname)";
                    OracleCommand addcmd = new OracleCommand(addtags, conn);
                    OracleParameter parn = new OracleParameter(":tname", _tags);
                    addcmd.Parameters.Add(parn);
                    int result=addcmd.ExecuteNonQuery();
                    if (result != 1)
                    {
                        throw new Exception("未能成功添加标签");
                    }
                    String gettagsid = "select tid from TAGS where tid in (select max(tid) as tid from TAGS)";
                    OracleCommand getcmd = new OracleCommand(gettagsid, conn);
                    OracleDataReader getdr = getcmd.ExecuteReader();
                    if(getdr.HasRows)
                    {
                        temp_tid = (int)getdr["tid"];  
                    }
                    else
                    {
                        throw new Exception("未知错误，代码为DPAT");
                    }
                }
                if(temp_tid!=0)
                {
                    String findmap = "select * from TAGSMAP where qid =" + qid+" and tid ="+ temp_tid;
                    OracleCommand find = new OracleCommand(findmap, conn);
                    OracleDataReader fdr = find.ExecuteReader();
                    if (fdr.HasRows)
                    {
                        String addrank = "Update TAGSMAP set tagnum=tagnum+1 where qid =" + qid + " and tid =" + temp_tid;
                        OracleCommand addr = new OracleCommand(addrank, conn);
                        int resultx = addr.ExecuteNonQuery();
                        if (resultx != 1)
                        {
                            throw new Exception("未能成功更新标签map");
                        }
                    }
                    else
                    {
                        String addtagsmap = "insert into TAGSMAP(tid,qid,tagnum) values(:tid,:qid,:tagnum)";
                        OracleCommand addmcmd = new OracleCommand(addtagsmap, conn);
                        OracleParameter parm1 = new OracleParameter(":tid", temp_tid);
                        OracleParameter parm2 = new OracleParameter(":qid", qid);
                        OracleParameter parm3 = new OracleParameter(":tagnum", 1);
                        addmcmd.Parameters.Add(parm1);
                        addmcmd.Parameters.Add(parm2);
                        addmcmd.Parameters.Add(parm3);
                        int result = addmcmd.ExecuteNonQuery();
                        if (result != 1)
                        {
                            throw new Exception("未能成功添加标签map");
                        }
                    }

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
        void IDataPumpAddTags.getQuestionInformation(ref string _questionID, ref string _questiontitle,int _qid,String _title)
        {
            _questionID = _qid.ToString();
            _questiontitle = _title;
        }
    }
}
