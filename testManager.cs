using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWHY;


interface IDataPump_Test
{
    void formTestManager();
}
namespace LWHY_test
{
    class testManager
    {
        public List<Question> ques;
        public IDataPumpSearchQueManager m_queBank = new DataPumpSearchQueManager();
        public void formTestManager(char pattern, int C_id, bool choice, bool gapFilling, bool TOF, bool calc, bool shortAns)//pattern刷题类型：e考试 p练习，C_id:题目分类
        {
            ques = m_queBank.SetOfSubQuestion(C_id);
            int n = ques.Count();
            for (int i = 0; i < n; i++)
            {
                switch (ques[i].type)
                {
                    case 'a':
                        if (choice == false)
                            ques.Remove(ques[i]);
                        break;
                    case 'b':
                        if (gapFilling == false)
                            ques.Remove(ques[i]);
                        break;
                    case 'c':
                        if (TOF == false)
                            ques.Remove(ques[i]);
                        break;
                    case 'd':
                        if (calc == false)
                            ques.Remove(ques[i]);
                        break;
                    case 'e':
                        if (shortAns == false)
                            ques.Remove(ques[i]);
                        break;
                }
            }
            if (pattern == 'e')
            {
                Exam tmp = new Exam();
                tmp.init(ques);
                tmp.Show();
            }
            else if (pattern == 'p')
            {
                //练习模式
                Practice tmp = new Practice();
                tmp.init(ques);
                tmp.Show();
            }            
        }
    }
}
