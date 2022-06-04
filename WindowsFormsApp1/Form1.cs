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

namespace Ebay
{
    public partial class Form1 : Form
    {
        IWebDriver driver;

        public Form1()
        {
            InitializeComponent();

            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(@"C:\Users\anast\Desktop\chromedriver", options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.ebay.com/";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            driver.Quit();
        }

        public bool Validate(string id)
        {
            bool isElementExist = driver.FindElement(By.Id(id)).Displayed;

            return isElementExist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            driver.FindElement(By.Id("gh-ac")).SendKeys(search);
            driver.FindElement(By.Id("gh-btn")).Click();

            string url = driver.Url;
            textBox2.Text = url;
            richTextBox1.Text += url + "\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }
    }
}
