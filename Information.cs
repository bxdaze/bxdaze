using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;


namespace LWHY
{
    class Information
    {


        private int iid;
        private String iname;
        private String iidcardnum;
        private String iphonenum;
        private String iaddress;
        private char isex;
        private int iage;
        private String iemail;
        private char irole;
        private Image iphoto;
        
       public Information()
        {
            iid = 0;
            iname = "";
            iidcardnum = "";
            iphonenum = "";
            iaddress = "";
            isex = '\0';
            iage = 0;
            iemail = "";
            irole = '\0';
            iphoto = null;
        }

       public  Information(int _id,String _name,String _idcardnum,String _phonenum,String _address,Char _sex,int _age,String _email,Char _role,Image _photo)
        {
            iid=_id;
            iname = _name;
            iidcardnum=_idcardnum;
            iphonenum=_phonenum;
            iaddress=_address;
            isex=_sex;
            iage=_age;
            iemail=_email;
            irole=_role;
            iphoto = _photo;
        }

     public   Information(Information _information)
        {
            iid = _information.id;
            iidcardnum = _information.idcardnum;
            iphonenum = _information.phonenum;
            iaddress = _information.address;
            isex = _information.sex;
            iage = _information.age;
            iemail = _information.email;
            irole = _information.role;
        }
        public int id
        {
            get
            {
                return iid;
            }
            set
            {
                iid = value;
            }
        }
        public String name
        {
            get
            {
                return iname;
            }
            set
            {
                iname = value;
            }
        }

        public String idcardnum
        {
            get
            {
                return iidcardnum;
            }
            set
            {
                iidcardnum = value;
            }
        }
        public String phonenum
        {
            get
            {
                return iphonenum;
            }
            set
            {
                iphonenum = value;
            }
        
        }

        public  String address
        {
            get
            {
                return iaddress;
            }
            set
            {
                iaddress = value;
            }
        }

        public Char sex
        {
            get
            {
                return isex;
            }
            set
            {
                isex = value;
            }
        }

        public int age
        {
            get
            {
                return iage;
            }
            set
            {
                iage = value;
            }
        }

        public String email
        {
            get
            {
                return iemail;
            }
            set
            {
                iemail = value;
            }
        }

        public Char role
        {
            get
            {
                return irole;
            }
            set
            {
                irole = value;
            }
        }
        public Image photo
        {
            get
            {
                return iphoto;
            }
            set
            {
                iphoto = value;
            }
        }
    }
}
