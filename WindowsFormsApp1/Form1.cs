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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver = new ChromeDriver(@"D:\Универ\Software Development Technologies\chromedriver-win64\chromedriver-win64");
        public Form1()
        {
            InitializeComponent();
            
            driver.Navigate().GoToUrl("https://www.ebay.com/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driver.FindElement(By.Id("gh-ac")).SendKeys(textBox1.Text);
            driver.FindElement(By.Id("gh-btn")).Click();
            string currentUrl = driver.Url;

            textBox2.Text = currentUrl;

            richTextBox1.AppendText(currentUrl);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://www.ebay.com/");
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
