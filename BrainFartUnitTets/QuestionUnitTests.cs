using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainFart.DAL;
using BrainFart.Model;
using BrainFart.Controller;
using BrainFart.DB;
using System.Collections.Generic;

namespace BrainFartUnitTests
{
    [TestClass]
    public class QuestionUnitTests
    {
        [TestMethod]
        public void TestGetAllQuestions()
        {
            List<Questions> questions = BrainFartController.GetAllQuestions();
            bool questionsFound = questions.Count == 30;
            Assert.AreEqual(true, questionsFound);
        }

    }
}


