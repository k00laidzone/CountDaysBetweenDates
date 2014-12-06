using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCDayCountTest.Controllers;
using MVCDayCountTest.Models;
using System.Web.Mvc;

namespace MVCDayCountTest.Tests
{
    [TestClass]
    public class DaysCountTest
    {
        [TestMethod]
        public void CountDaysBetweenOctAndDec()
        {
            //arrange
            string StartDate    = "10/1/2014";
            string EndDate      = "12/1/2014";

            //act
            var controller      = new MainController();
            var results         = (ViewResult)controller.Index(StartDate, EndDate);
            var model           = (NumberOfDays)results.Model;

            //assert
            Assert.AreEqual(61, model.FinalCount);

        }
        [TestMethod]
        public void CountDaysBetweenJan1AndDec31()
        {
            //arrange
            string StartDate = "1/1/2014";
            string EndDate = "12/31/2014";

            //act
            var controller = new MainController();
            var results = (ViewResult)controller.Index(StartDate, EndDate);
            var model = (NumberOfDays)results.Model;

            //assert
            Assert.AreEqual(364, model.FinalCount);

        }

        [TestMethod]
        public void CountDaysBetweenOct12014AndJan312015()
        {
            //arrange
            string StartDate = "10/1/2014";
            string EndDate = "1/31/2015";

            //act
            var controller = new MainController();
            var results = (ViewResult)controller.Index(StartDate, EndDate);
            var model = (NumberOfDays)results.Model;

            //assert
            Assert.AreEqual(122, model.FinalCount);

        }
    }
}
