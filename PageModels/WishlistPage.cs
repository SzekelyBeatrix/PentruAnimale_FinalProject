using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PentruAnimale_FinalProject.PageModels
{
    class WishlistPage : BasePage
    {
        const string mainPageFavoriteButtonSelector = "/html/body/header/div/div/div/div[2]/ul/li[4]/a";
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
        /*public void AddToWishlist()
        {
            var catalogButton = Utils.WaitForElementClickable(driver, 10, (By.Id(catalogButtonSelector)));
            catalogButton.Click();
            var neonsCatalogButton = Utils.WaitForElementClickable(driver, 10, (By.XPath(neonsButtonSelector)));
            neonsCatalogButton.Click();
            var productsAddToCart = Utils.WaitForElementClickable(driver, 10, (By.XPath(productsAddToCartButton)));
            productsAddToCart.Click();
            var addToWishlist = Utils.WaitForElementClickable(driver, 10, (By.CssSelector(addToWishlistSelector)));
            addToWishlist.Click();
        }*/
    }
}
