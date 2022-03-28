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
        const string accountButtonSelector = "body > header > div > div > div > div.col-md-5.col-sm-4.col-xs-12 > ul > li:nth-child(5) > a"; //xpath
        const string inregistreazaTeButtonSelector = "doRegister"; //id
        const string numeLabelSelector = "//*[@id='registrationFields']/div[1]/label[1]/span"; //xpath
        const string numeInputSelector = "//*[@id='registrationFields']/div[1]/label[1]/input";//xpath
        const string prenumeInputSelector = "//*[@id='registrationFields']/div[1]/label[2]/input";//xpath
        const string emailInputSelector = "//*[@id='registrationFields']/div[1]/label[3]/input";//xpath
        const string parolaInputSelector = "//*[@id='registrationFields']/div[1]/label[4]/input";//xpath
        const string inregistreazaButtonSelector = "doRegister";//id
        const string checkoferteBoxSelector = "#registrationFields > div.ofert-section > p.ofert-check > input"; //css
        const string checkpromotionsBoxSelector = "info-check-input"; //id

        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }


        public void MoveToRegisterPage()
        {
            Thread.Sleep(5000);
            var accountButton = Utils.Utils.WaitForElementClickable(driver, 20, By.CssSelector(accountButtonSelector));
            accountButton.Click();

            var inregistreazaTeButton = Utils.Utils.WaitForFluentElement(driver, 20, By.Id(inregistreazaTeButtonSelector));
            inregistreazaTeButton.Click();

        }

        public Boolean CheckRegisterLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.XPath(clientNouLabelSelector)).Text.ToLower());
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
            // driver.FindElement(By.CssSelector(checkoferteBoxSelector)).Click();
            //driver.FindElement(By.Id(checkpromotionsBoxSelector)).Click(); they come by default checked, you can uncheck it with this function
            var inregistreazaButton = driver.FindElement(By.Id(inregistreazaButtonSelector));
            inregistreazaButton.Submit();

        }
        public void CheckErrorColor()
        {
            var nameError = driver.FindElement(By.XPath(numeLabelSelector));
           String errorColor= nameError.GetCssValue(".error");
            if (errorColor.Equals("#d90404"))
                Console.WriteLine("The RegistrationNegativ WORKS!!!");
            else
                Console.WriteLine("I am unable to find the Error Color!");
        }
    }
}
