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
        const string loginPageLabelSelector = "inputClient"; //class
        const string emailInputSel = "_loginEmail"; //id
        const string emailErrorSel = "body > div.container-h.clearfix.mainContainer > div.container-h.mobile-np.clearfix > div.cart-page > div > div.acount-log.cart-box.col-lg-4.col-md-4.col-sm-4.pull-right.row > span"; //css
        const string passwordInputSel = "_loginPassword"; // id
        const string loginButtonSel = "doLogin";//id

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public Boolean CheckLoginLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.CssSelector(loginPageLabelSelector)).Text.ToLower());
        }

        public string CheckPage()
        {
            var loginPageEl = driver.FindElement(By.CssSelector(loginPageLabelSelector));
            return loginPageEl.Text;
        }
        public void Login(string email, string password)
        {
            var emailInputElement = Utils.Utils.WaitForFluentElement(driver, 7, By.Id(emailInputSel));
            emailInputElement.Clear();
            emailInputElement.SendKeys(email);
            var passwordInputElement = Utils.Utils.WaitForFluentElement(driver, 20, By.Id(passwordInputSel));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(password);
            var loginButtonElement = driver.FindElement(By.CssSelector(loginButtonSel));
            loginButtonElement.Submit();
        }
        public Boolean CheckErrorMessage(string emailErr)
        {
            Thread.Sleep(7000);
            return String.Equals(emailErr.ToLower(), driver.FindElement(By.CssSelector(emailErrorSel)).Text.ToLower());
        }
    }
}
