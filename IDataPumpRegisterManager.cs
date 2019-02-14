using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWHY
{
    interface IDataPumpRegisterManager
    {
        bool checkName(string _name);//用户名是否存在
        void updateRegisterInformation(User _userinformation, Information _registerinformation);//插入用户信息。
    }
}
