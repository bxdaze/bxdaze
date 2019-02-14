using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWHY;
using LWHY题库及学习系统;

interface IDataPump_Login
{
    User isAlive(string tb_User);//判断登录是否有效 1用户 2管理员 3错误
}

namespace WindowsFormsApp_login
{
    class LoginManager
    {
        User temp_user;

        public int isLogin(string temp_User, string temp_Password)
        {
            IDataPump_Login temp_datapump = new DataPump_Login();
            temp_user = temp_datapump.isAlive(temp_User);
            if (temp_user != null)
            {
                if (!isOnline(temp_user))
                {
                    if (isPasswordRight(temp_user, temp_Password))
                    {
                        Global.TheOnlyUser.nickname = temp_user.nickname;
                        Global.TheOnlyUser.userid = temp_user.userid;
                        Global.TheOnlyUser.isOnline = true;
                        return 1;//用户登陆成功
                    }
                    else
                    {
                        return 2;//用户密码错误
                    }
                }
                else
                {
                    return 3;//用户已登陆
                }
            }
            else
            {
                return 4;//用户不存在
            }
        }

        private bool isOnline(User temp_user)
        {
            return temp_user.isOnline;
        }

        private bool isPasswordRight(User temp_user,string temp_Password)
        {
            if (temp_user.password == temp_Password)
                return true;
            else
                return false;
        }
    }
}
