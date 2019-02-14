using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWHY
{
    public class Classification
    {
        private int iCId;
        private String[] iClassification;
        

       public Classification()
        {
            iCId = 0;
            iClassification = new String[5];
            
        }

      public  Classification(int _cId,String[] _Cla,String _secCla,String _thrCla,String _forCla,String _fifCla)
        {
            iCId = _cId;
            iClassification = _Cla;
           

        }

      public  Classification(Classification _Cla)
        {
            iCId = _Cla.cId;
            iClassification = _Cla.Cla;
           

        }
      public Classification(int _cId, String[] _Cla)
      {
          iCId = _cId;
          iClassification = _Cla;


      }
        public int cId
        {
            get { return iCId;}
            set { iCId = value; }
        }
        public String[] Cla
        {
            get { return iClassification; }
            set { iClassification = value; }
        }

       
    }
}
