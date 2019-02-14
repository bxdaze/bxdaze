using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWHY;
using System.Drawing;



namespace WindowsFormsUser
{
    class UserManage
    {
        List<Question> collectQuestion;
        Information UserInfo;
        public UserManage(User temp_use)
        {
            IDataPumpUserManage temp_ium = new DataPump_UserManage();
            collectQuestion = temp_ium.getCollectQuestion(temp_use.userid);
            UserInfo = temp_ium.getUserInfo(temp_use.userid);
        }

        public List<Question> cQuestion
        {
            get
            {
                return collectQuestion;
            }
            set
            {
                collectQuestion = null;
            }
        }

        public String name
        {
            get
            {
                return UserInfo.name;
            }
            set
            {
                UserInfo.name = value;
            }
        }

        public String phonenum
        {
            get
            {
                return UserInfo.phonenum;
            }
            set
            {
                UserInfo.phonenum = value;
            }

        }

        public String address
        {
            get
            {
                return UserInfo.address;
            }
            set
            {
                UserInfo.address = value;
            }
        }

        public String sex
        {
            get
            {
                return UserInfo.sex.ToString();
            }
            set
            {
                UserInfo.sex = value[0];
            }
        }

        public int age
        {
            get
            {
                return UserInfo.age;
            }
            set
            {
                UserInfo.age = value;
            }
        }

        public String email
        {
            get
            {
                return UserInfo.email;
            }
            set
            {
                UserInfo.email = value;
            }
        }

        public Image photo
        {
            get
            {
                return UserInfo.photo;
            }
            set
            {
                UserInfo.photo = value;
            }
        }

    }
}
