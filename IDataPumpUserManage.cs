using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWHY;

namespace WindowsFormsUser
{
    interface IDataPumpUserManage
    {
        List<Question> getCollectQuestion(int userID);
        Information getUserInfo(int userID);
    }
}
