using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PentruAnimale_FinalProject.PageModels
{
    class RegisterPage : BasePage
    {
        const string clientNouLabelSelector = "/html/body/div[2]/div[1]/div[1]/div/div[1]/h1"; //xpath
        const string accountButtonSelector = "/html/body/header/div/div/div/div[2]/ul/li[5]/a"; //xpath
        const string inregistreazaTeButtonSelector = "doRegister"; //id
        const string numeLabelSelector = "//*[@id='registrationFields']/div[1]/label[1]/span"; //xpath
        const string numeInputSelector = "//*[@id='registrationFields']/div[1]/label[1]/input";//xpath
        const string prenumeInputSelector = "//*[@id='registrationFields']/div[1]/label[2]/input";//xpath
        const string emailInputSelector = "//*[@id='registrationFields']/div[1]/label[3]/input";//xpath
        const string parolaInputSelector = "//*[@id='registrationFields']/div[1]/label[4]/input";//xpath
        const string inregistreazaButtonSelector = "doRegister";//id


        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }


        public void MoveToRegisterPage()
        {
            var accountButton = Utils.Utils.WaitForElementClickable(driver, 20, By.XPath(accountButtonSelector));
            accountButton.Click();

            var inregistreazaTeButton = Utils.Utils.WaitForFluentElement(driver, 20, By.Id(inregistreazaTeButtonSelector));
            inregistreazaTeButton.Click();

        }

        public Boolean CheckRegisterLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.CssSelector(clientNouLabelSelector)).Text.ToLower());
        }


        public void RegisterUser(string fname, string lname, string email, string pass)
        {
            driver.FindElement(By.XPath(numeLabelSelector));
            var numeInput = driver.FindElement(By.XPath(numeInputSelector));
            numeInput.Clear();
            numeInput.SendKeys(fname);
            var prenumeInput = driver.FindElement(By.XPath(prenumeInputSelector));
            prenumeInput.Clear();
            prenumeInput.SendKeys(lname);
            var emailInput = driver.FindElement(By.XPath(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var passInput = driver.FindElement(By.XPath(parolaInputSelector));
            passInput.Clear();
            passInput.SendKeys(pass);
            var inregistreazaButton = driver.FindElement(By.Id(inregistreazaButtonSelector));
            inregistreazaButton.Submit();

        }
    }
}
