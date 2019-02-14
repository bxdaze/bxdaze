using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWHY
{
    interface IDataPumpSearchQueManager
    {
        List<Question> SetOfSubQuestion( int Cla);//指示课程分类的那个String数组类 ques存储cla这个分类下所有题目
        List<Question>  SetOfClaQuestion(char Cla);//ques存储所有Cla类型的题目（选择 判断 这种）
        Question FindOneQuestion(int qId);//参数为问题的编码（key），返回该问题所有内容
        List<Question> QuestionTitleSearch(String title);//给出标题关键词，返回包含该关键词的所有问题
        List<Question> QuestionTagSearch(String tag);//给出tag关键词，返回包含该关键词的所有问题
        List<Question> QuestionClaSearch(String cla);//给出分类关键词，返回包含该关键词的所有问题
        List<Classification> SetOfClassification();//给出所有分类；

        void addcllection(int qid, int userid);//添加收藏
    }
}
