using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWHY;


namespace RecordQuestion
{
    interface IDataPumpAddquesManager
    {
        //int getQuetionID();//获得一个未被使用的新ID
        bool AddNewquestion(Question temp, Classification where);//添加一个新题
    }
}
