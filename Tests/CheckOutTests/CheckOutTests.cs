using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PentruAnimale_FinalProject.Tests.CheckOutTests
{
    class CheckOutTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        [Test]
        public void PursueAddToCartTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseCookies();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            Assert.IsTrue(lp.CheckLoginLabel("Intra in Cont"));
            lp.Login("abcde@yahoo.com", "123456789");


            /*CartPage cp = new CartPage(_driver);
             Assert.IsTrue(cp.CheckpromotionsTextLabel("Promotii"));*/

            CheckOutPage cop = new CheckOutPage(_driver);
            cop.NavigateToCartPage();
            /*cop.NavigateToCheckOut();
            cop.OpenExtenderAddToCart();*/

        }
        [Test]
        public void CheckOutTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseCookies();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            Assert.IsTrue(lp.CheckLoginLabel("Intra in Cont"));
            lp.Login("abcde@yahoo.com", "123456789");

            CheckOutPage cop = new CheckOutPage(_driver);
            cop.NavigateToCartPage();
            cop.FinalOrderNavigator();
            Assert.IsTrue(cop.WeSaveThemFromSomeTrouble("Pentru a trimite comanda, completati urmatoarele informatii"));
            

        }
    }
}