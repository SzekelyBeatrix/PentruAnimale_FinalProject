using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PentruAnimale_FinalProject.Tests.CheckOutTests
{
    class CheckOutTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl() + promotionsPath;

        [Test]
        public void addToCartTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseCookies();
            mp.MoveToMenuPage();

           /* CartPage cp = new CartPage(_driver);
            Assert.IsTrue(cp.CheckpromotionsTextLabel("Promotii"));*/

            CheckOutPage cop = new CheckOutPage(_driver);
            cop.NavigateToCheckOut();

        }
    }
}