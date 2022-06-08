using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TEST_WindowsFormsApp2
{
    public partial class Test_Form1 : Form
    {
        [Test]
        public void Test()
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(@"C:\Users\zukvl\Downloads\Exam2022pavasaris\chromedriver_win32");
            driver.Url = "https://www.ebay.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("gh-ac")).Click();
            driver.Quit();
        }

    }
}
