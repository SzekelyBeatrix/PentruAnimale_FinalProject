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
    public class CheckOutPage : BasePage
    {
        const string promotionsTextLabelSelector = "/html/body/div[2]/div[4]/div[1]/h1"; //Xpath
        const string addToCartButtonsSelector = "prod-add-cart-btn"; //class
        const string productDetailsCheckOutExtenderSelector = "#productInfo > a > u"; //Css
        const string CheckOutExtenderAddToCartSelector = "//*[@id='addToCartButton']/span"; //xpath
        const string shippingTextSelector = "deliveryInformation";//id
        const string mainPageCartButtonSelector = "//*[@id='_cartSummary']/a";//xpath
        const string closePromotionPopupButtonSelector = "//*[@id='ue_push_dialog']/div[2]/div[2]/button[1]";//xpath
        const string moveToElementSelector = "/html/body/div[2]/div[4]/div[3]/div[3]/ul/li[2]/a[1]/img";//xpath
        public CheckOutPage(IWebDriver driver) : base(driver)
        {
        }

        public Boolean CheckpromotionsTextLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.XPath(promotionsTextLabelSelector)).Text.ToLower());
        }


        public void NavigateToCheckOut()
        {
            var addToCartButton = Utils.Utils.WaitForFluentElement(driver, 15, By.ClassName(addToCartButtonsSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(addToCartButton);
            Thread.Sleep(5000);
            driver.FindElement(By.ClassName(addToCartButtonsSelector)).Click();

           /* Thread.Sleep(10000);
            driver.FindElement(By.Id(shippingTextSelector));
            driver.FindElement(By.XPath(closePromotionPopupButtonSelector)).Click();
            var CheckOutExtenderAddToCart = Utils.Utils.WaitForElementClickable(driver, 10, By.XPath(CheckOutExtenderAddToCartSelector));
            CheckOutExtenderAddToCart.Submit();
            driver.FindElement(By.XPath(mainPageCartButtonSelector)).Click();*/
        }

    }
}



