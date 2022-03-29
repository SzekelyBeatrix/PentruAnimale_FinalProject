using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace PentruAnimale_FinalProject.Tests.ProfileDataTest
{
    class ProfileDataTest : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            foreach (var values in Utils.Utils.GetGenericData("TestData\\authenticationData.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        [Test, TestCaseSource("GetCredentialsDataCsv")]
        public void AddDataToProfile(string modifName, string modifPrenume, string company, string region, string city, string address, string phone, string dob)
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

            ProfileData pd = new ProfileData(_driver);
            pd.NavigateToPersonalDataForm();
            pd.CheckPage();
            Thread.Sleep(10000);
            pd.TypeInPersonalData(modifName,modifPrenume,company,region,city,address,phone,dob);
        }

    }
}
