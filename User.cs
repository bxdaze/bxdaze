using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWHY
{
    class User
    {
        private int iUserId;
        private String iNickname;
        private String iPassword;
        private Boolean iIsOnline;

        public User()
        {
            iUserId = 0;
            iPassword = "";
            iNickname="";
            iIsOnline = false;
        }
       public User(int _userid,String _inickname,String _password,Boolean _isonline)
        {
            iUserId = _userid;
            iPassword = _password;
            iIsOnline = _isonline;
            iNickname=_inickname;
        }
      public  User ( User _user)
        {
            iUserId = _user.userid;
            iPassword = _user.password;
            iIsOnline = _user.isOnline;
            iNickname = _user.iNickname;

         }
        public int userid
        {
            get
            {
                return iUserId;
            }

            set
            {
                iUserId = value;
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
        public Boolean isOnline
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
