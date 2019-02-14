using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWHY
{
   public class Question
    {
        private int iQuestionId;
        private String iTitle;
        private String iBody;
        private String iAnswer;
        private String iTAGs;
        private  char iType;// a:选择题，b：判断题，c：计算，d简答。
      

     public   Question()
        {
            iQuestionId = 0;
            iTitle = "";
            iBody = "";
            iAnswer = "";
            iTAGs = "";
            iType ='\0';
        }

      public  Question(int _questionId,String _title,String _body,String _answer,String _tags,char _type)
        {
            iQuestionId = _questionId;
            iTitle = _title;
            iBody = _body;
            iAnswer = _answer;
            iTAGs = _tags;
            iType = _type;
        }

      public Question(Question _question)
        {
            iQuestionId = _question.questionId;
            iTitle = _question.title;
            iBody = _question.body;
            iAnswer = _question.answer;
            iTAGs = _question.tags;
            iType = _question.type;
        }
       

        public int questionId
        {
            get
            {
                return iQuestionId;
            }
            set
            {
                iQuestionId = value;
            }
        }

        public String title
        {
            get
            {
                return iTitle;
            }
            set
            {
                iTitle = value;
            }
        }
        
        public String body
        {
            get
            {
                return iBody;
            }
            set
            {
                iBody = value;
            }
        }

        public String answer
        {
            get
            {
                return iAnswer;
            }
            set
            {
                iAnswer = value;
            }
        }

        public String tags
        {
            get
            {
                return iTAGs;
            }
            set
            {
                iTAGs = value;
            }
        }
        public char type
        {
            get
            {
                return iType;
            }
            set
            {
                iType = value;
            }
        }
  


    }
}
