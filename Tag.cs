using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWHY
{
    class Tag
    {
        private int iTagId;
        private String iTagName;
        private int iTagNum;

        Tag()
        {
            iTagId = 0;
            iTagName = "";
            iTagNum = 0;
        }

        Tag(int _tagid,String _tagName,int _tagNum)
        {
            iTagId = _tagid;
            iTagName = _tagName;
            iTagNum = _tagNum;
        }

        Tag(Tag _tag)
        {
           // iTagId = _tag.TagId;

        }

        public int tagId
        {
            get
            {
                return iTagId;
            }
            set
            {
                iTagId = value;
            }
        }
        
        public String tagName
        {
            get
            {
                return iTagName;
            }
            set
            {
                iTagName = value;
            }
        }

        public int tagNum
        {
            get
            {
                return iTagNum;
            }
            set
            {
                iTagNum = value;
            }
        }
    }
}
