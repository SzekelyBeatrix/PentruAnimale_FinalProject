using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PentruAnimale_FinalProject.PageModels
{
   /* class CartPage : BasePage
    {
        const string accountButtonSelector = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-obj-options.obj-move-right.tt-position-absolute > div.tt-desctop-parent-account.tt-parent-box > div > button";//css
        const string mainPageCartButtonSelector = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-obj-options.obj-move-right.tt-position-absolute > div.tt-desctop-parent-account.tt-parent-box > div > div > div.tt-dropdown-inner > ul > li:nth-child(3) > a"; //css
        const string emptyCartText = "#tt-pageContent > div.container-indent.nomargin.tt-empty-cart-js > div > h1"; //css
        const string continueShopButton = "#tt-pageContent > div.container-indent.nomargin.tt-empty-cart-js > div > a"; //css
        const string catalogButtonSelector = "same_product_height"; //id
        const string productsAddToCartButton = "//*[@id='tt-pageContent']/div/div/div/div[2]/div/div[2]/div[1]/div/div[2]/h2/a";//xpath
        const string collectionsButtonSelector = "#tt-pageContent > div > div > div > div.col-md-4.col-lg-3.col-xl-3.leftColumn.aside > div:nth-child(3) > h3";//css
        const string neonsButtonSelector = "//*[@id='tt-pageContent']/div/div/div/div[1]/div[3]/div/ul/li[2]/a"; //xpath
        const string sizeButtonSelector = "//*[@id='shopify-section-product-template']/div[1]/div[2]/div/div[2]/div/div[5]/div[1]/ul/li[4]/a"; //xpath
        const string addToWishlistSelector = "#shopify-section-product-template > div:nth-child(1) > div.container.container-fluid-mobile > div > div:nth-child(2) > div > div.tt-wrapper.select_options > div > ul > li > a > span";
        const string addToCartButtonSelector = "#product_form_6828233490581 > div.tt-row-custom-01 > div:nth-child(2) > button > span:nth-child(2)";
        const string expandedViewCartButtonSelector = "//*[@id='modalAddToCartProduct']/div/div/div[2]/div[2]/div/div[2]/a[3]";//xpath
        const string shoppingCartTermsTextSelector = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(3) > div > div > label";//css
        const string checkOutTermsCheckBoxSelector = "//*[@id='modalAddToCartProduct']/div/div/div[2]/div[1]/div[2]/div/label/span[1]";
        const string checkOutButtonSelector = "//*[@id='modalAddToCartProduct']/div/div/div[2]/div[1]/a[3";







        const string shoppingCarttext = "#updateform > h1"; //css
        const string clearShopSelector = "#updateform > div.tt-shopcart-table-02 > div > div.col-right > a"; //css
        const string shippingCartText = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(1) > div > h4"; //css
        const string shippingCountryText = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(1) > div > div > div:nth-child(1) > label"; //css
        const string shippingCountryInputSelector = "address_country";//id
        const string shippingStateText = "#address_province_container > label";
        const string shippingStateInputSelector = "address_province"; //id
        const string shippingZipText = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(1) > div > div > div:nth-child(3) > label";
        const string shippingZipInputSelector = "address_zip"; //id
        const string shippingZipErrorText = "shipping-rates-feedback"; //id
        const string calculateShippingButtonSelector = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(1) > div > div > button";
        const string grandTotalText = "grandtotal"; //id
        const string termsInputElem = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(3) > div > div > label > span.check";//css
        //prima oara sa dea click pe buttonul cart din pagina
        public CartPage(IWebDriver driver) : base(driver)
        {

        }
      

        public void MoveToViewCartPage()
        {
            driver.FindElement(By.CssSelector(accountButtonSelector)).Click();
            var cartButton = Utils.WaitForElementClickable(driver, 20, By.CssSelector(mainPageCartButtonSelector));
            cartButton.Click();

        }

       public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(emptyCartText)).Text; //de verificat aici daca nu e mai ok cu shopping Carttext
        }
        public void ShoppingCart()
        {
            var shopButton = Utils.WaitForElementClickable(driver, 20, By.CssSelector(continueShopButton));
            shopButton.Click(); 
        }
        public void AddToCartNavigator()
        {
            var catalogButton = Utils.WaitForElementClickable(driver, 10, (By.Id(catalogButtonSelector)));
            catalogButton.Click();
            var neonsCatalogButton= Utils.WaitForElementClickable(driver, 10, (By.XPath(neonsButtonSelector)));
            neonsCatalogButton.Click();
            var productsAddToCart = Utils.WaitForElementClickable(driver, 10, (By.XPath(productsAddToCartButton)));
            productsAddToCart.Click();
            driver.FindElement(By.XPath(sizeButtonSelector)).Click();
            driver.FindElement(By.CssSelector(addToCartButtonSelector)).Click();
            var expandedViewCartButton = Utils.WaitForElementClickable(driver, 10, (By.XPath(expandedViewCartButtonSelector)));
            expandedViewCartButton.Click();

        }

    }*/
}
