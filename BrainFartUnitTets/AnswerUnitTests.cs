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
    public class AnswerUnitTests
    {
        [TestMethod]
        public void TestGetAllAnswers()
        {
            List<Answers> answers = BrainFartController.GetAllAnswerChoices(1);
            bool questionsFound = answers.Count == 4;
            Assert.AreEqual(true, questionsFound);
        }
    }
}
