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

        public static List<Categories> getAllCategories()
        {
            return CategoriesDAL.GetAllCategories();
        }

        public static List<Difficulties> getAllDifficulties()
        {
            return DifficultiesDAL.GetAllDifficulties();
        }

        public static int AddQuestion(Questions question)
        {
            return QuestionsDAL.AddQuestion(question);
        }

        public static bool UpdateQuestion(Questions question, Questions newQuestion)
        {
            throw new NotImplementedException();
        }
    }
}
