using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PentruAnimale_FinalProject.PageModels
{
    public class ProfileData : BasePage
    {
        const string PersonalDataButtonSelector = "body > div.container-h.clearfix.mainContainer > div > div.cart-page > div > div.acount-menu.col-lg-3.col-md-3.col-sm-3 > div:nth-child(2) > ul > li:nth-child(2) > a";//class
        const string PersonalDataLabelSelector = "/html/body/div[2]/div/div[1]/div/h1";//xpath
        const string dataModifNameInputSelector = "#customerForm > form > div:nth-child(2) > input"; //css
        const string dataModifPrenumeInputSelector = "#customerForm > form > div:nth-child(5) > input"; //css
        const string companyInputSelector = "#customerForm > form > div:nth-child(8) > input"; //css
        const string regionInputSelector = "#customerForm > form > div:nth-child(11) > select"; //css
        const string cityInputSelector = "#customerForm > form > div:nth-child(14) > input"; //css
        const string addressInputSelector = "#customerForm > form > div:nth-child(17) > input"; //css
        const string phoneInputSelector = "#customerForm > form > div:nth-child(20) > input"; //css
        const string genderInputSelector = "#customerForm > form > div:nth-child(23) > select"; //css
        const string dobInputSelector = "#customerForm > form > div:nth-child(26) > select:nth-child(1)"; //css
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

        public void TypeInPersonalData(string modifName,string modifPrenume,string company,string region,string city,string address,string phone,string dob)
        {
           
            var dataModifNameInput = driver.FindElement(By.CssSelector(dataModifNameInputSelector));
            dataModifNameInput.Clear();
            dataModifNameInput.SendKeys(modifName);
            var dataModifPrenumeInput = driver.FindElement(By.CssSelector(dataModifPrenumeInputSelector));
            dataModifNameInput.Clear();
            dataModifNameInput.SendKeys(modifPrenume);
            var companyInput = driver.FindElement(By.CssSelector(companyInputSelector));
            companyInput.Clear();
            companyInput.SendKeys(company);
            var regionInput = driver.FindElement(By.CssSelector(regionInputSelector));
            regionInput.Clear();
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
            var genderInput = driver.FindElement(By.CssSelector(genderInputSelector));
            genderInput.Click();
            var dobInput = driver.FindElement(By.CssSelector(dobInputSelector));
            dobInput.Clear();
            dobInput.SendKeys(dob);
            var saveButton = driver.FindElement(By.CssSelector(saveButtonSelector));
            saveButton.Submit();
        }
    }
  
}
