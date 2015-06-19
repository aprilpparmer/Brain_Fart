using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainFart.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainFart.DAL;
using BrainFart.DB;
using BrainFart.Controller;





namespace BrainFart.Model.Tests
{
    [TestClass()]
    public class QuestionsUnitTests
    {
        private Questions question;
        private List<Questions> questionList;

        [ClassInitialize()]
        public static void QuestionsUnitTestsInitialize(TestContext context)
        {
            //MessageBox.Show("ClassInit");
        }

        [TestMethod()]
        public void TestGetAllQuestions()
        {
            List<Questions> questionList = new List<Questions>();
            this.questionList = BrainFartController.GetAllQuestions(); 
           
        }
    }
}
