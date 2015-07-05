using BrainFart.DAL;
using BrainFart.Model;
using BrainFart.Controller;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainFartUnitTests
{
    [TestClass]
    public class DifficultiesUnitTests
    {
        private List<Difficulties> difficultyList;


        //Test Methods to check Controller for getAllCategories
        [TestMethod]
        public void TestgetAllDifficulties()
        {
            this.difficultyList = BrainFartController.getAllDifficulties();
            bool allCategoriesSuccess = difficultyList.Count > 1;

            Assert.AreEqual(true, allCategoriesSuccess);
        }

        [TestMethod]
        public void TestgetAllCategoriesReturnsFalse()
        {
            this.difficultyList = BrainFartController.getAllDifficulties();
            bool allQuestionsSuccess = difficultyList.Count == 1;

            Assert.AreEqual(false, allQuestionsSuccess);
        }
    }
}
