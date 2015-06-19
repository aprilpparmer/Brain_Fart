using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainFart.Controller;
using BrainFart.Model;
using BrainFart.DAL;
using BrainFart.DB;
using System.Collections.Generic;



namespace BrainFartTests
{
    [TestClass]
    public class QuestionUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Questions> questionList = BrainFartController.GetAllQuestions();

            bool questionsfound = questionList.Count > 0;

            Assert.AreEqual(true, questionsfound);
        }
    }
}
