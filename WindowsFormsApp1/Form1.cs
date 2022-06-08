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
using OpenQA.Selenium.Firefox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
            driver = new FirefoxDriver(@"C:\users\lusis\Desktop\EKA\Programmaturas izstrades tehnologijas\");
            driver.Url = "https://www.ebay.com";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Searchkey = textBox1.Text;
            IWebElement Searchbar = driver.FindElement(By.Id("gh-ac"));
            Searchbar.SendKeys(Searchkey);
            IWebElement Poga = driver.FindElement(By.Id("gh-btn"));
            Poga.Click();
            textBox2.Text = driver.Url;
            richTextBox1.AppendText(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Close();
        }
    }
}
