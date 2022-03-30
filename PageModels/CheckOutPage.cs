using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace PentruAnimale_FinalProject.PageModels
{
    public class CheckOutPage : BasePage
    {
        const string mainPageCartButtonSelector = "#_cartSummary > a"; //css
        const string promotionsTextLabelSelector = "/html/body/div[2]/div[4]/div[1]/h1"; //Xpath
        const string addToCartButtonsSelector = "prod-add-cart-btn"; //class
        const string productDetailsCheckOutExtenderSelector = "#productInfo > a > u"; //Css
        const string CheckOutExtenderAddToCartSelector = "//*[@id='addToCartButton']/span"; //xpath
        const string shippingTextSelector = "deliveryInformation";//id
        const string closePromotionPopupButtonSelector = "//*[@id='ue_push_dialog']/div[2]/div[2]/button[1]";//xpath
        const string moveToElementSelector = "/html/body/div[2]/div[4]/div[3]/div[3]/ul/li[2]/a[1]/img";//xpath
        const string finalOrderCheckOutButtonSelector = "#subtotal-section > div > div > div > div:nth-child(3) > div > div > div:nth-child(5) > div > a.final-order.main-btn";
        const string finalOrderNewsLetterSelector = "newsletterAdd"; //id
        const string finalOrderCheckTermsSelector = "body > div.container-h.cart-holder.clearfix > div > div > div > div.cart-step2 > div.terms > label > input[type=checkbox]"; //css
        const string DoCheckOutButtonSelector = "doCheckout";//id
        const string errorMessageFinalCheckOut = "error"; //for ethical reasons :), but it works if we send a city imput
        public CheckOutPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToCartPage()
        {
            driver.FindElement(By.CssSelector(mainPageCartButtonSelector)).Click();
        }

        public Boolean CheckpromotionsTextLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.XPath(promotionsTextLabelSelector)).Text.ToLower());
        }


        public void NavigateToCheckOut()
        {
            var addToCartButton = Utils.Utils.WaitForFluentElement(driver, 20, By.ClassName(addToCartButtonsSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(addToCartButton);
            driver.FindElement(By.ClassName(addToCartButtonsSelector)).Click();
        }

        public void OpenExtenderAddToCart()
        {
            driver.FindElement(By.Id(shippingTextSelector));
            var CheckOutExtenderAddToCart = Utils.Utils.WaitForElementClickable(driver, 10, By.XPath(CheckOutExtenderAddToCartSelector));
            CheckOutExtenderAddToCart.Submit();
            driver.FindElement(By.XPath(mainPageCartButtonSelector)).Click();
        }

        public void FinalOrderNavigator()
        {
            driver.FindElement(By.CssSelector(finalOrderCheckOutButtonSelector)).Click();
            driver.FindElement(By.Id(finalOrderNewsLetterSelector)).Click();
            driver.FindElement(By.CssSelector(finalOrderCheckTermsSelector)).Click();
            driver.FindElement(By.Id(DoCheckOutButtonSelector)).Click();
        }
        public Boolean WeSaveThemFromSomeTrouble(string errorMessage)
        {

            return String.Equals(errorMessage.ToLower(), driver.FindElement(By.ClassName(errorMessageFinalCheckOut)).Text.ToLower());

        }

    }
}



