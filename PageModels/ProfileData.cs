using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PentruAnimale_FinalProject.PageModels
{
    public class ProfileData : BasePage
    {
        const string PersonalDataButtonSelector = "body > div.container-h.clearfix.mainContainer > div > div.cart-page > div > div.acount-menu.col-lg-3.col-md-3.col-sm-3 > div:nth-child(2) > ul > li:nth-child(2) > a";//class
        const string PersonalDataLabelSelector = "/html/body/div[2]/div/div[1]/div/h1";//xpath
        const string dataModifNameLabelSelector = "#customerForm > form > div:nth-child(1)"; //css
        const string dataModifNameInputSelector = "//*[@id='customerForm']/form/div[2]/input"; //css
        const string dataModifPrenumeInputSelector = "#customerForm > form > div:nth-child(5) > input"; //css
        const string companyInputSelector = "#customerForm > form > div:nth-child(8) > input"; //css
        const string regionInputSelector = "#customerForm > form > div:nth-child(11) > select"; //css
        const string regionInputSibSelector = "#customerForm > form > div:nth-child(11) > select > option:nth-child(42)";
        const string cityInputSelector = "#customerForm > form > div:nth-child(14) > input"; //css
        const string addressInputSelector = "#customerForm > form > div:nth-child(17) > input"; //css
        const string phoneInputSelector = "#customerForm > form > div:nth-child(20) > input"; //css
        const string genderInputSelector = "#customerForm > form > div:nth-child(23) > select"; //css
        const string dobdayInputSelector = "#customerForm > form > div:nth-child(26) > select:nth-child(1)"; //css
        const string dobmonthInputSelector = "#customerForm > form > div:nth-child(26) > select:nth-child(2)"; //css
        const string dobyearInputSelector = "#customerForm > form > div:nth-child(26) > select:nth-child(3)"; //css
        const string saveButtonSelector = "//*[@id='doSave']/span"; //xpath
        public ProfileData(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToPersonalDataForm()
        {
            driver.FindElement(By.CssSelector(PersonalDataButtonSelector)).Click();
        }

        public string CheckPage()
        {
            var PersonalDataLabel = driver.FindElement(By.CssSelector(PersonalDataLabelSelector));
            return PersonalDataLabel.Text;
        }

        public void TypeInPersonalData(string modifName, string modifPrenume, string company,string region, string city, string address, string phone,string gender, string dobday, string dobmonth, string dobyear)
        {
            driver.FindElement(By.CssSelector(dataModifNameLabelSelector));
            var dataModifNameInput = Utils.Utils.WaitForFluentElement(driver, 20, By.XPath(dataModifNameInputSelector));
            dataModifNameInput.Clear();
            dataModifNameInput.SendKeys(modifName);
            var dataModifPrenumeInput = Utils.Utils.WaitForFluentElement(driver, 20, By.CssSelector(dataModifPrenumeInputSelector));
            dataModifPrenumeInput.Clear();
            dataModifPrenumeInput.SendKeys(modifPrenume);
            var companyInput = driver.FindElement(By.CssSelector(companyInputSelector));
            companyInput.Clear();
            companyInput.SendKeys(company);
            var regionInput = Utils.Utils.WaitForFluentElement(driver, 10, By.CssSelector(regionInputSelector));
            regionInput.Click();
            regionInput.SendKeys(region);
            var cityInput = driver.FindElement(By.CssSelector(cityInputSelector));
            cityInput.Clear();
            cityInput.SendKeys(city);
            var addressInput = driver.FindElement(By.CssSelector(addressInputSelector));
            addressInput.Clear();
            addressInput.SendKeys(address);
            var phoneInput = driver.FindElement(By.CssSelector(phoneInputSelector));
            phoneInput.Clear();
            phoneInput.SendKeys(phone);
            var genderInput = Utils.Utils.WaitForFluentElement(driver, 10, By.CssSelector(genderInputSelector));
            genderInput.Click();
            genderInput.SendKeys(region);
            var dobdayInput = driver.FindElement(By.CssSelector(dobdayInputSelector));
            dobdayInput.Click();
            dobdayInput.SendKeys(dobday);
            var dobmonthInput = driver.FindElement(By.CssSelector(dobmonthInputSelector));
            dobmonthInput.Click();
            dobmonthInput.SendKeys(dobmonth);
            var dobyearInput = driver.FindElement(By.CssSelector(dobyearInputSelector));
            dobyearInput.Click();
            dobyearInput.SendKeys(dobyear);
            var saveButton = driver.FindElement(By.XPath(saveButtonSelector));
            saveButton.Submit();
        }
    }

}
