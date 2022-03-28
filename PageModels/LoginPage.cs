using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PentruAnimale_FinalProject.PageModels
{
    class LoginPage : BasePage
    {
        const string intraInContLabelSelector = "body > div.container-h.clearfix.mainContainer > div.container-h.mobile-np.clearfix > div.cart-page > div > div.acount-log.cart-box.col-lg-4.col-md-4.col-sm-4.pull-right.row > h2";
        const string loginPageLabelSelector = "inputClient"; 
        const string emailLabelSel = "/html/body/div[2]/div[1]/div[1]/div/div[2]/form/label[1]/span";//xpath
        const string emailInputSel = "_loginEmail"; //id
        const string emailErrorSel = "body > div.container-h.clearfix.mainContainer > div.container-h.mobile-np.clearfix > div.cart-page > div > div.acount-log.cart-box.col-lg-4.col-md-4.col-sm-4.pull-right.row > span"; //css
        const string passwordInputSel = "_loginPassword"; // id
        const string loginButtonSel = "doLogin";//id
        const string closepromotiiPushLabelSelector = "#ue_push_dialog > div.__ue__content > div:nth-child(2) > h6"; //css
        const string closepromotiiPushButtonSelector = "//*[@id='ue_push_dialog']/div[2]/div[2]/button[1]"; //xpath

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public Boolean CheckLoginLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.Id(loginPageLabelSelector)).Text.ToLower());
        }

        public string CheckPage()
        {
            var loginPageEl = driver.FindElement(By.CssSelector(intraInContLabelSelector));
            return loginPageEl.Text;
        }

        public void ClosePopUp()
        {
            driver.FindElement(By.CssSelector(closepromotiiPushLabelSelector));
            var closepromotiiPush = Utils.Utils.WaitForElementClickable(driver, 20, By.XPath(closepromotiiPushButtonSelector));
            closepromotiiPush.Click();

        }

        public void Login(string email, string password)
        {
            driver.FindElement(By.XPath(emailLabelSel));
            var emailInputElement = Utils.Utils.WaitForFluentElement(driver,20,By.Id(emailInputSel));
            emailInputElement.Clear();
            emailInputElement.SendKeys(email);
            var passwordInputElement = driver.FindElement(By.Id(passwordInputSel));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(password);
            var loginButtonElement = driver.FindElement(By.Id(loginButtonSel));
            loginButtonElement.Submit();
        }
        public Boolean CheckErrorMessage(string emailErr)
        {
            Thread.Sleep(7000);
            return String.Equals(emailErr.ToLower(), driver.FindElement(By.CssSelector(emailErrorSel)).Text.ToLower());
        }
    }
}
