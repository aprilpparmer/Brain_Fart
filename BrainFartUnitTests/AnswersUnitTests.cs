﻿using BrainFart.DAL;
using BrainFart.Model;
using BrainFart.Controller;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BrainFartUnitTests
{

    [TestClass]
    public class AnswersUnitTests
    {
        private List<Answers> answerList;

        //Tests to check controller is returning all 4 answers per question
        [TestMethod]
        public void TestGetAllQuestions()
        {
            this.answerList = BrainFartController.GetAllAnswerChoices(1);
            bool allAnswersSuccess = answerList.Count == 4;

            Assert.AreEqual(true, allAnswersSuccess);
        }
        [TestMethod]
        public void TestGetAllQuestionsReturnGreaterThanOne()
        {
            this.answerList = BrainFartController.GetAllAnswerChoices(1);
            bool allAnswersSuccess = answerList.Count > 1;

            Assert.AreEqual(true, allAnswersSuccess);
        }
        [TestMethod]
        public void TestGetAllQuestionsReturnsFalse()
        {
            this.answerList = BrainFartController.GetAllAnswerChoices(1);
            bool allAnswersSuccess = answerList.Count == 1;

            Assert.AreEqual(false, allAnswersSuccess);
        }
        [TestMethod]
        public void TestGetAllQuestionsQuestionID()
        {
            this.answerList = BrainFartController.GetAllAnswerChoices(21);
            bool allAnswersSuccess = answerList.Count == 4;

            Assert.AreEqual(true, allAnswersSuccess);
        }
        [TestMethod]
        public void TestGetAllQuestionsReturnGreaterThanOneQuestionID()
        {
            this.answerList = BrainFartController.GetAllAnswerChoices(21);
            bool allAnswersSuccess = answerList.Count > 1;

            Assert.AreEqual(true, allAnswersSuccess);
        }
        [TestMethod]
        public void TestGetAllQuestionsReturnsFalseQuestionID()
        {
            this.answerList = BrainFartController.GetAllAnswerChoices(21);
            bool allAnswersSuccess = answerList.Count == 1;

            Assert.AreEqual(false, allAnswersSuccess);
        }
    }
}
