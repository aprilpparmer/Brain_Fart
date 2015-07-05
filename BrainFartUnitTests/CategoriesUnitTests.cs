using BrainFart.DAL;
using BrainFart.Model;
using BrainFart.Controller;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainFartUnitTests
{
    [TestClass]
    public class CategoriesUnitTests
    {
        private List<Categories> categoryList;


        //Test Methods to check Controller for getAllCategories
        [TestMethod]
        public void TestgetAllCategories()
        {
            this.categoryList = BrainFartController.getAllCategories();
            bool allCategoriesSuccess = categoryList.Count > 1;

            Assert.AreEqual(true, allCategoriesSuccess);
        }

        [TestMethod]
        public void TestgetAllCategoriesReturnsFalse()
        {
            this.categoryList = BrainFartController.getAllCategories();
            bool allQuestionsSuccess = categoryList.Count == 1;

            Assert.AreEqual(false, allQuestionsSuccess);
        }
    }
}
