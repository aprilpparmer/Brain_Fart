using BrainFart.DAL;
using BrainFart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Controller
{
    class BrainFartController
    {
        public static List<Questions> GetAllQuestions()
        {
            return QuestionsDAL.GetAllQuestions();
        }
    }
}
