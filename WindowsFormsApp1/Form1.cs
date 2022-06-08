using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddExcludedArgument("enable-logging");
            chromeOptions.AddArguments("--headless");
            driver = new ChromeDriver(@"C:\Users\zukvl\Downloads\Exam2022pavasaris\chromedriver_win32");
            driver.Url = "https://www.ebay.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("gh-ac")).Click();


            String search = driver.PageSource;
            Console.WriteLine("Search resukt is : " + search);
            richTextBox1.Text = search;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            driver.Navigate().GoToUrl("https://www.ebay.com");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }
    }
}
