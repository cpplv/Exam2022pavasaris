using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string DRIVER_DIR = @"D:\visual-studio\md3\ProductFinder\BrowserDriver";
        IWebDriver driver;

        private IWebDriver getDriver()
        {
            if (driver == null)
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("headless");

                driver = new ChromeDriver(DRIVER_DIR, chromeOptions);
                return driver;
            }

            return driver;
        }

        [TestMethod]
        public void Test1_field()
        {
            getDriver().Url = "https://www.ebay.com/";

            IWebElement searchField = getDriver().FindElement(By.CssSelector("#gh-ac"));
            Assert.IsTrue(searchField.Displayed);
        }

        [TestMethod]
        public void Test2_search()
        {
            getDriver().Url = "https://www.ebay.com/";

            IWebElement searchField = getDriver().FindElement(By.CssSelector("#gh-btn"));
            Assert.IsTrue(searchField.Displayed);
        }
    }
}