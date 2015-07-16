using BrainFart.DAL;
using BrainFart.Model;
using BrainFart.Controller;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BrainFartUnitTests
{
    [TestClass]
    public class GamesUnitTests
    {
       
        [TestMethod]
        public void TestAddUserStats()
        {
            Games addStats = new Games();
            BrainFartController.DeleteStats(14);
            addStats.UserID = 14;
            addStats.QuestionsCorrect = 4;
            addStats.QuestionsMissed = 4;

            int newStats = BrainFartController.AddUserStats(addStats);

            int statsCorrect = BrainFartController.userQuestionsCorrect(14);
            bool addStatsCorrectSuccess = statsCorrect == 4;

            int statsMissed = BrainFartController.userQuestionsMissed(14);
            bool addStatsMissedSuccess = statsCorrect == 4;

            Assert.AreEqual(true, addStatsCorrectSuccess);
            Assert.AreEqual(true, addStatsMissedSuccess);

            BrainFartController.DeleteStats(14);

        }

        [TestMethod]
        public void TestUserStatsReturn0whenNull()
        {
            BrainFartController.DeleteStats(14);
            int stats = BrainFartController.userQuestionsCorrect(14);
            bool addStatstSuccess = stats == 0;
            Assert.AreEqual(true, addStatstSuccess);
            BrainFartController.DeleteStats(14);
        }

        [TestMethod]
        public void TestSumMaxAvgUserStats()
        {
            Games addStats = new Games();
            BrainFartController.DeleteStats(14);
            addStats.UserID = 14;
            addStats.QuestionsCorrect = 4;
            addStats.QuestionsMissed = 4;
            addStats.Score = 100;

            int newStats = BrainFartController.AddUserStats(addStats);

            int statsAvg = BrainFartController.userGamesAvg(14);
            bool addStatsCorrectSuccess = statsAvg == 100;

            int statsMax = BrainFartController.userHighScore(14);
            bool addStatsMissedSuccess = statsMax == 100;

            Assert.AreEqual(true, addStatsCorrectSuccess);
            Assert.AreEqual(true, addStatsMissedSuccess);

            BrainFartController.DeleteStats(14);

        }

        [TestMethod]
        public void TestGamesPlayedUserStats()
        {
            Games addStats = new Games();
            BrainFartController.DeleteStats(14);
            addStats.UserID = 14;
            addStats.QuestionsCorrect = 4;
            addStats.QuestionsMissed = 4;
            addStats.Score = 100;

            int newStats = BrainFartController.AddUserStats(addStats);

            int gamesPlayed = BrainFartController.userGamesPlayed(14);
            bool addStatsCorrectSuccess = gamesPlayed == 1;

            Assert.AreEqual(true, addStatsCorrectSuccess);

            BrainFartController.DeleteStats(14);

        }

    }
}
