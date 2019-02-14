using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWHY;

interface IDataPump_Search
{
    void kindOfSearch(int type, String str, List<Question> ans);//搜索类型编号，搜索关键字，搜索题目结果
}

namespace LWHY_Search
{
    class searchManager
    {
       public List<Question> kindOfSearch(int type,String str)
        {
            IDataPumpSearchQueManager tmp = new DataPumpSearchQueManager();
            switch(type)//连接数据库搜索
            {
                case 0://标题搜索
                    return tmp.QuestionTitleSearch(str);
                    break;
                case 1://tag搜索
                    return tmp.QuestionTagSearch(str);
                    break;
                case 2://分类搜索   
                    return tmp.QuestionClaSearch(str);
                    break;
                default:
                    return null;
            }
        }
    }
}
