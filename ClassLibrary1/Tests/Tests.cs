using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace ClassLibrary1.Tests
{
    internal class Tests
    {
        IWebDriver _driver;

        [SetUp]
        public void InitializeWebDriver()
        {
            var options = new ChromeOptions();
            this._driver = new ChromeDriver(@"C:\Users\KristineR\Documents\EKA\Programmaturas izstrades teh\chromedriver_win32", options);
            this._driver.Url = "https://www.ebay.com/";
        }

        [Test]
        public void TestMethodSearchFieldElementFound()
        {           
            IWebElement search = this._driver.FindElement(By.Id("gh-ac"));
            Assert.IsTrue(search.Displayed);
        }

        [Test]
        public void TestMethodButtonElementFound()
        {
            IWebElement button = this._driver.FindElement(By.Id("gh-btn"));
            Assert.IsTrue(button.Displayed);
        }
    }
}
