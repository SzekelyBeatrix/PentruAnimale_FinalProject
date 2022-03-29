using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PentruAnimale_FinalProject.Tests.WishlistTests
{
    class WishlistTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        [Test]
        public void WishlistTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseCookies();

            WishlistPage wp = new WishlistPage(_driver);
            wp.WishlistNavigator();

            LoginPage lp = new LoginPage(_driver);
            Assert.IsTrue(lp.CheckLoginLabel("Intra in Cont"));
            lp.Login("abcde@yahoo.com", "123456789");

            wp.AddToWishlist();
            

        }
    }
}
