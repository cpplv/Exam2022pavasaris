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
        private const string DRIVER_DIR = @"C:\Visual-Studio\chromedriver";
        IWebDriver driver;
        public static string DRIVER_DIR1 => DRIVER_DIR;
        public Form1()
        {
            InitializeComponent();
            driver = new ChromeDriver(DRIVER_DIR1);
            driver.Url = "https://www.ebay.com/";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string searchKey = textBox1.Text != "" ? textBox1.Text : "notebook";
            IWebElement searchField = driver.FindElement(By.CssSelector("#gh-ac"));
            IWebElement searchButton = driver.FindElement(By.CssSelector("#gh-btn"));
            searchField.SendKeys(searchKey);
            searchButton.Click();
            textBox2.Text = driver.Url;
            richTextBox1.AppendText(driver.Url);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            driver.Navigate().Back();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }
    }
    internal interface IWebElement
    {
    }
}