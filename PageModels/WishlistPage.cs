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
    class WishlistPage : BasePage
    {
        const string mainPageFavoriteButtonSelector = "/html/body/header/div/div/div/div[2]/ul/li[4]/a";
        const string addWishListButtonSelector = "//*[@id='addToWishlist']/img"; //xpath
        const string addToCartButtonsSelector = "prod-add-cart-btn"; //class
        const string wishListButtonSelector = "wishlist-btn";//class
        public WishlistPage(IWebDriver driver) : base(driver)
        {
        }

       /* public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(WishlistTextSelector)).Text;
        }*/
        public void WishlistNavigator()
        {
  
            driver.FindElement(By.XPath(mainPageFavoriteButtonSelector)).Click();

        }
        public void AddToWishlist()
        {
          var addToCartButton = Utils.Utils.WaitForFluentElement(driver, 15, By.ClassName(addToCartButtonsSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(addToCartButton);
            Thread.Sleep(5000);
            driver.FindElement(By.ClassName(addToCartButtonsSelector)).Click();
            driver.FindElement(By.ClassName(addToCartButtonsSelector)).Click();
        }
    }
}
