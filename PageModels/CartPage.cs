using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PentruAnimale_FinalProject.PageModels
{
    class CartPage : BasePage
    {
        const string promotionsTextLabelSelector = "/html/body/div[2]/div[4]/div[1]/h1"; //Xpath
        const string addToCartButtonsSelector = "prodHolder"; //tagname

        public CartPage(IWebDriver driver) : base(driver)
        {

        }


        public Boolean CheckpromotionsTextLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.XPath(promotionsTextLabelSelector)).Text.ToLower());
        }

        public void AddToCart(int itemIndex)
        {

            var addButtons = driver.FindElements(By.TagName(addToCartButtonsSelector));
            //var button = addButtons[itemIndex];
            Console.Write(addButtons.Count);
            //Buttons.Click();

        }
    }

}
