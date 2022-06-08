using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace Test1_Field
{

    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            driver = new FirefoxDriver(@"C:\users\lusis\Desktop\EKA\Programmaturas izstrades tehnologijas\");
            driver.Url = "https://www.ebay.com";
            Assert.IsTrue(driver.FindElement(By.Id("gh-ac")).Displayed);
        }
    }
}
