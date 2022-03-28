using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PentruAnimale_FinalProject.PageModels
{
    public class MainPage : BasePage
    {
        const string acceptCookiesSelector = "cc-cookie-accept"; //class
        const string accountButtonSelector = "/html/body/header/div/div/div/div[2]/ul/li[5]/a";//xpath
       


        const string pageTextSelector = "#home-stories > h2"; //css
        const string collectionsButtonSelector = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-desctop-parent-menu.tt-parent-box.tt-obj-menu > div > nav > ul > li:nth-child(1) > a > span";
        const string catalogButtonSelector = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-desctop-parent-menu.tt-parent-box.tt-obj-menu > div > nav > ul > li:nth-child(2) > a > span";
        const string searchButtonSelector = "#shopify-section-header-template > header > div.tt-mobile-header.tt-mobile-header-inline.tt-mobile-header-inline-stuck > div > div > div.tt-mobile-parent-menu-icons > div.tt-mobile-parent-search.tt-parent-box > div > button";//css
        const string cartButtonSelector = "#shopify-section-header-template > header > div.tt-mobile-header.tt-mobile-header-inline.tt-mobile-header-inline-stuck > div > div > div.tt-mobile-parent-menu-icons > div.tt-mobile-parent-cart.tt-parent-box > div > button";//css

        const string loginButtonExpandedSelector = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-obj-options.obj-move-right.tt-position-absolute > div.tt-desctop-parent-account.tt-parent-box > div > div > div.tt-dropdown-inner > ul > li:nth-child(1) > a";

        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        public void CloseCookies()
        {
            var acceptCookie = Utils.Utils.WaitForFluentElement(driver, 10, By.ClassName(acceptCookiesSelector));
            acceptCookie.Click();
        }

        public void MoveToLoginPage()
        {
            var accountButton = Utils.Utils.WaitForElementClickable(driver, 20, By.XPath(accountButtonSelector));
            accountButton.Click();

        }

      

    }

}
