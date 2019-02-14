using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAndTagsAdd
{
    interface IDataPumpAddTags
    {
        void addTagsRank(string _tags,int qid);
        void getQuestionInformation(ref string _questionID, ref string _questiontitle,int _qid,String _title);
    }
}
