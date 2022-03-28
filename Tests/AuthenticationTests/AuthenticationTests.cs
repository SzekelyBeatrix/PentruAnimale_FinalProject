using NUnit.Framework;
using PentruAnimale_FinalProject.Tests;
using PentruAnimale_FinalProject.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using PentruAnimale_FinalProject.PageModels;
using System.Threading;

namespace PentruAnimale_FinalProject.Tests
{
    class AuthenticationTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        [Test]
        public void AuthenticationPositive()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseCookies();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            lp.CheckPage();
            /*lp.ClosePopUp();*/
            lp.Login("aabb@gmail.com", "Aabbaabb");
            /*Thread.Sleep(5000);
            Assert.IsTrue(lp.CheckErrorMessage("Incorrect email or password."));*/
        }
        //[Test]
        /*public void AuthenticationNegativ()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseCookies();
            mp.CheckMainPageButtons();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            Assert.IsTrue(lp.CheckLoginLabel("Login"));
            lp.Login(Utils.Utils.GenerateRandomStringCount(10) + "@check.com", Utils.Utils.GenerateRandomStringCount(10));*/


    }
}