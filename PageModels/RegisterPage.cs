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
        const string accountButtonSelector = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-obj-options.obj-move-right.tt-position-absolute > div.tt-desctop-parent-account.tt-parent-box > div > button";//css
        const string registerButtonExpandedSelector = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-obj-options.obj-move-right.tt-position-absolute > div.tt-desctop-parent-account.tt-parent-box > div > div > div.tt-dropdown-inner > ul > li:nth-child(2) > a"; //css
        const string createAccountTextSelector = "#tt-pageContent > div > div > h1";
        const string firstNameLabelSelector = "#create_customer > div:nth-child(4) > label";
        const string firstNameInputSelector = "loginInputName";  // First Name is a * Required Field, but does not have an error message for empty values
        const string lastNameLabelSelector = "#create_customer > div:nth-child(5) > label";
        const string lastNameInputSelector = "loginLastName"; // Last Name is a * Required Field, but does not have an error message for empty values
        const string emailLabelSelector = "#create_customer > div:nth-child(6) > label";
        const string emailInputSelector = "loginInputEmail";
        const string emailErrorSelector = "#create_customer > div.tt-base-color > div > ul > li:nth-child(2)";
        const string passwordLabelSelector = "#create_customer > div:nth-child(7) > label";
        const string passwordInputSelector = "loginInputPassword";
        const string passwordErrorSelector = "#create_customer > div.tt-base-color > div > ul > li:nth-child(1)";
        const string createSelector = "#create_customer > div.row > div:nth-child(1) > div > button";
        const string returnToStoreSelector = "#create_customer > div.row > div.col-auto.align-self-center > div > ul > li > a";



        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }
        public Boolean CheckRegisterLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.CssSelector(createAccountTextSelector)).Text.ToLower());
        }

        public void MoveToRegisterPage()
        {
            driver.FindElement(By.CssSelector(accountButtonSelector)).Click();
            driver.FindElement(By.CssSelector(registerButtonExpandedSelector)).Click();

        }

        public void RegisterUser(string fname, string lname, string email, string pass)
        {
            var firstNameInput = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInput.Clear();
            firstNameInput.SendKeys(fname);
            Thread.Sleep(10000); //for captcha reasons
            var lastNameInput = driver.FindElement(By.Id(lastNameInputSelector));
            lastNameInput.Clear();
            lastNameInput.SendKeys(lname);
            Thread.Sleep(10000); //for captcha reasons
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            Thread.Sleep(10000); //for captcha reasons
            var passInput = driver.FindElement(By.Id(passwordInputSelector));
            passInput.Clear();
            passInput.SendKeys(pass);
            Thread.Sleep(10000); //for captcha reasons
            var createButton = driver.FindElement(By.CssSelector(createSelector));
            createButton.Submit();

        }
        public void CheckReturnRegisterPage()
        {
            Thread.Sleep(7000);//for captcha reasons
            var checkRegisterReturnPage = Utils.Utils.WaitForElementClickable(driver, 340, By.CssSelector(accountButtonSelector));
            checkRegisterReturnPage.Click(); 
        }
    }
}
