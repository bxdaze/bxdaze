using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWHY
{
    class FeedBack
    {
        private int iFId;
        private char iClassfication;
        private String iBrief;
        private String iDescription;

       public FeedBack()
        {
            iFId = 0;
            iClassfication = '\0';
            iBrief = "";
            iDescription = "";
        }

       public  FeedBack(int _fId,char _classfication,String _brief,String _description)
        {
            iFId = _fId;
            iClassfication = _classfication;
            iBrief = _brief;
            iDescription = _description;
        }

        public FeedBack(FeedBack _feedback)
        {
            iFId = _feedback.fId;
            iClassfication = _feedback.classfication;
            iBrief = _feedback.brief;
            iDescription = _feedback.description;

        }
       
        public int fId
        {
            get
            {
                return iFId;
            }
            set
            {
                iFId = value;
            }
        }

        public char classfication
        {
            get
            {
                return iClassfication;
            }
            set
            {
                iClassfication = value;
            }
        }
        public String brief
        {
            get
            {
                return iBrief;
            }
            set
            {
                iBrief = value;
            }
        }
        public String description
        {
            get
            {
                return iDescription;
            }
            set
            {
                iDescription = value;
            }
        }
    }
}
