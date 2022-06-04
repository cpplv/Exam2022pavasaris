using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {

        IWebDriver driver;
    
        [TestMethod]
        public void Test1_field()
        {
             driver = new ChromeDriver(@"D:\Privatie faili\EKA\Izstrade\chromedriver_win32");
             driver.Url = "https://www.ebay.com/";
           IWebElement serchField =  driver.FindElement(By.CssSelector("#gh-ac"));
            Assert.IsNotNull(serchField);
        }

        [TestMethod]
        public void Test2_serch()
        {
            driver = new ChromeDriver(@"D:\Privatie faili\EKA\Izstrade\chromedriver_win32");
            driver.Url = "https://www.ebay.com/";
            IWebElement serchField = driver.FindElement(By.CssSelector("#gh-btn"));
            Assert.IsNotNull(serchField);
        }
    }
}
