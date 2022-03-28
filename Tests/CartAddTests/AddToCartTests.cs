using PentruAnimale_FinalProject.PageModels;
using PentruAnimale_FinalProject.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PentruAnimale_FinalProject.Tests.CartAdd
{
    class AddToCartTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl()+ promotionsPath;

        [Test]
        public void addToCartTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            CartPage cp = new CartPage(_driver);
            Assert.IsTrue(cp.CheckpromotionsTextLabel("Promotii"));
            cp.AddToCart(0);

        }


    }
}
