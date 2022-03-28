using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PentruAnimale_FinalProject.PageModels
{
    public class CheckOutPage : BasePage
    {
        const string promotionsTextLabelSelector = "/html/body/div[2]/div[4]/div[1]/h1"; //Xpath
        const string addToCartButtonsSelector = "body > div.container-h.clearfix.mainContainer > div.categ-section.clearfix.shadowed > div.categories-list.col-xs-12.col-lg-9.col-md-9.col-sm-9.no-padding > div.listed-categories > ul > li:nth-child(2) > a.prod-image.__prodUrl"; //css
        const string productDetailsCheckOutExtenderSelector = "#productInfo > a > u"; //Css
        const string CheckOutExtenderAddToCartSelector = "addToCartButton"; //id
        const string shippingTextSelector = "deliveryInformation";//id
        const string mainPageCartButtonSelector = "//*[@id='_cartSummary']/a";//xpath

        public CheckOutPage(IWebDriver driver) : base(driver)
        {
        }

        public Boolean CheckpromotionsTextLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.XPath(promotionsTextLabelSelector)).Text.ToLower());
        }


        public void NavigateToCheckOut()
        {
           driver.FindElement(By.CssSelector(addToCartButtonsSelector)).Click();
           driver.FindElement(By.Id(shippingTextSelector));
           var CheckOutExtenderAddToCart = Utils.Utils.WaitForElementClickable(driver, 10, By.Id(CheckOutExtenderAddToCartSelector));
            CheckOutExtenderAddToCart.Click();
            driver.FindElement(By.XPath(mainPageCartButtonSelector)).Click();
        }

    }
}



