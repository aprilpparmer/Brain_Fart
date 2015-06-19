using BrainFart.DAL;
using BrainFart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Controller
{
    public class BrainFartController
    {
        public static List<Questions> GetAllQuestions()
        {
            return QuestionsDAL.GetAllQuestions();
        }

        public static List<Answers> GetAllAnswerChoices(int questionID)
        {
            return AnswersDAL.GetAllAnswerChoices(questionID);
        }
    }
}
