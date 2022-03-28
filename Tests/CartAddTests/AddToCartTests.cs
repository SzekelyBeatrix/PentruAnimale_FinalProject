using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PentruAnimale_FinalProject.Tests.CartAdd
{
    class AddToCartTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        [Test]
        public void addToCartTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseCookies();

            /*CartPage cp = new CartPage(_driver);
            cp.MoveToViewCartPage();
            cp.CheckPage();
            cp.ShoppingCart();
            cp.AddToCartNavigator();*/
        }


    }
}
