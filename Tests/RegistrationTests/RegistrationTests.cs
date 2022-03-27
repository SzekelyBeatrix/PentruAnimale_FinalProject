using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PentruAnimale_FinalProject.Tests.RegistrationTests
{
    class RegistrationTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv2()
        {
            foreach (var values in Utils.Utils.GetGenericData("TestData\\authenticationData.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        [Test]
        public void RegistrationTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            /*MainPage mp = new MainPage(_driver);
            mp.CloseCookies();
            mp.CheckMainPageButtons();*/

            RegisterPage rp = new RegisterPage(_driver);
            rp.MoveToRegisterPage();
            Assert.IsTrue(rp.CheckRegisterLabel("CREATE AN ACCOUNT"));
            // rp.RegisterUser("aaaaaa","aaa","aaaa@yahoo.com","aaaaa");
            rp.RegisterUser(Utils.Utils.GenerateRandomStringCount(10), Utils.Utils.GenerateRandomStringCount(10), Utils.Utils.GenerateRandomStringCount(10) + "@check.com", Utils.Utils.GenerateRandomStringCount(10)); ;
            rp.CheckReturnRegisterPage();


        }
    }
}
