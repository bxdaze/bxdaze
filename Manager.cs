using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWHY
{
    class Manager
    {
        private int iManagerId;
        private String iNickname;
        private String iPassword;
        private Boolean iIsOnline;

        Manager()
        {
            iManagerId = 0;
            iPassword = "";
            iNickname="";
            iIsOnline = false;
        }
        Manager(int _managerid,String _inickname,String _password,Boolean _isonline)
        {
            iManagerId = _managerid;
            iPassword = _password;
            iIsOnline = _isonline;
            iNickname=_inickname;
        }
        Manager( Manager _manager)
        {
            iManagerId = _manager.userid;
            iPassword = _manager.password;
            iIsOnline = _manager.isonline;
            iNickname = _manager.nickname;

         }
        public int userid
        {
            get
            {
                return iManagerId;
            }

            set
            {
                iManagerId = value;
            }
        }
        public String nickname
        {
            get
            {
                return iNickname;
            }
            set
            {
                iNickname = value;
            }
        }
        public String password
        {
            get 
            {
                return iPassword;
            }
            set 
            {
                iPassword = value;
            }
        }
        public Boolean isonline
        {
            get
            {
                return iIsOnline;
            }

            set
            {
                iIsOnline = value;
            }
        }

    }
}
