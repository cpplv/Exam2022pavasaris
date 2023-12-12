using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace ClassLibrary1.TestCases
{
    internal class Class1
    {
        [Test]
        public void Test1()
        {
            //var options = new ChromeOptions();
            //options.AddExcludedArgument("enable-logging");
            IWebDriver driver = new ChromeDriver(@"D:\Универ\Software Development Technologies\chromedriver-win64\chromedriver-win64");
            driver.Url = "https://www.ebay.com/";
            driver.FindElement(By.Id("gh-ac"));

            driver.Quit();
        }

        [Test]
        public void Test2()
        {
            //var options = new ChromeOptions();
            //options.AddExcludedArgument("enable-logging");
            IWebDriver driver = new ChromeDriver(@"D:\Универ\Software Development Technologies\chromedriver-win64\chromedriver-win64");
            driver.Url = "https://www.ebay.com/";

            driver.FindElement(By.Id("gh-btn"));
            driver.Quit();
        }

    }
}
