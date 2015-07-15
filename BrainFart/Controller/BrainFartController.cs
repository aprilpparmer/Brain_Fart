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

        public static int AddAnswer(Answers answer)
        {
            return AnswersDAL.AddAnswer(answer);
        }

        public static List<Questions> GetQuestionsFromCategoryWithDifficulty(int categoryID, int difficultyID)
        {
            return QuestionsDAL.GetQuestionsFromCategoryWithDifficulty(categoryID, difficultyID);
        }

        public static List<Questions> GetQuestionsFromCategory(int categoryID)
        {
            return QuestionsDAL.GetQuestionsFromCategory(categoryID);
        }
        
        public static List<Questions> GetQuestionsFromDifficulty(int difficultyID)
         {
              return QuestionsDAL.GetQuestionsFromDifficulty(difficultyID);
         }

        public static int AddUserStats(Games game)
        {
            return GamesDAL.AddUserStats(game);
        }

        public static int userGamesPlayed(int userID)
        {
            return GamesDAL.userGamesPlayed(userID);
        }

        public static int userGamesAvg(int userID)
        {
            return GamesDAL.userGamesAvg(userID);
        }

        public static int userHighScore(int userID)
        {
            return GamesDAL.userHighScore(userID);
        }

        public static int userQuestionsMissed(int userID)
        {
            return GamesDAL.userQuestionsMissed(userID);
        }

        public static int userQuestionsCorrect(int userID)
        {
            return GamesDAL.userQuestionsCorrect(userID);
        }

        public static bool DeleteStats(int removeUser)
        {
            return GamesDAL.DeleteStats(removeUser);
        }
    }
}
