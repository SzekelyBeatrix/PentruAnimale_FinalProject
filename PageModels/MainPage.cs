using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace PentruAnimale_FinalProject.PageModels
{
    public class MainPage : BasePage
    {
        const string acceptCookiesSelector = "cc-cookie-accept"; //class
        const string accountButtonSelector = "body > header > div > div > div > div.col-md-5.col-sm-4.col-xs-12 > ul > li:nth-child(5) > a"; //xpath
        const string menuButtonSelector = "#logo > a.menu-btn-s > i";//css
        const string promotionsButtonSelector = "//*[@id='main-navigation']/div[1]/ul/li[1]/a";//xpath
        const string allPromotionsButtonSelector = "//*[@id='main-navigation']/div[1]/ul/li[1]/div/ul/li[1]/a";//xpath

        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        public void CloseCookies()
        {
            var acceptCookie = Utils.Utils.WaitForFluentElement(driver, 2, By.ClassName(acceptCookiesSelector));
            acceptCookie.Click();
        }

        public void MoveToLoginPage()
        {
            Thread.Sleep(5000);
            var accountButton = Utils.Utils.WaitForElementClickable(driver, 15, By.CssSelector(accountButtonSelector));
            accountButton.Click();
        }

        public void MoveToMenuPage()
        {
           // driver.FindElement(By.CssSelector(menuButtonSelector)).Click();
            var hoverPromotionButton = driver.FindElement(By.XPath(promotionsButtonSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(hoverPromotionButton);
            driver.FindElement(By.XPath(allPromotionsButtonSelector)).Click();
        }
    }

}
