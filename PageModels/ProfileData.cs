using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PentruAnimale_FinalProject.PageModels
{
    public class ProfileData : BasePage
    {
        const string PersonalDataButtonSelector = "activeFilterHead";//class
        const string PersonalDataLabelSelector = "/html/body/div[2]/div/div[1]/div/h1";//xpath
        public ProfileData(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToPersonalDataForm()
        {
            driver.FindElement(By.ClassName(PersonalDataButtonSelector)).Click(); 
        }

        public string CheckPage()
        {
            var PersonalDataLabel = driver.FindElement(By.CssSelector(PersonalDataLabelSelector));
            return PersonalDataLabel.Text;
        }
    }
  
}
