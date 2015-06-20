using BrainFart.DAL;
using BrainFart.Model;
using BrainFart.Controller;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainFartUnitTests
{
    [TestClass]
    public class QuestionsUnitTests
    {
        private List<Questions> questionList;

        //Test Methods to check Controller for getAllTestsQuestions
        [TestMethod]
        public void TestGetAllQuestions()
        {
            this.questionList = BrainFartController.GetAllQuestions();
            bool allQuestionsSuccess = questionList.Count == 30;

            Assert.AreEqual(true, allQuestionsSuccess);
        }

        [TestMethod]
        public void TestGetAllQuestionsGreaterThanOne()
        {
            this.questionList = BrainFartController.GetAllQuestions();
            bool allQuestionsSuccess = questionList.Count > 1;

            Assert.AreEqual(true, allQuestionsSuccess);
        }

        [TestMethod]
        public void TestGetAllQuestionsReturnsFalse()
        {
            this.questionList = BrainFartController.GetAllQuestions();
            bool allQuestionsSuccess = questionList.Count == 1;

            Assert.AreEqual(false, allQuestionsSuccess);
        }
    }
}
