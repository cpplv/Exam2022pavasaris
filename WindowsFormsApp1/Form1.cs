using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

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
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            IWebDriver driver = new ChromeDriver(@"C:\Users\apoim\Documents\PIT\Chrome\", options);
            string search = textBox1.Text;
            driver.Url = "https://ebay.com";
            driver.FindElement(By.Id("gh-ac")).SendKeys(search);
            driver.FindElement(By.Id("gh-btn")).Click();
            String PageURL = driver.Url;
            textBox2.Text = PageURL;
            richTextBox1.AppendText(PageURL);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
