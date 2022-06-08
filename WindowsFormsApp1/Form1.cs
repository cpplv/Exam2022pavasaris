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
using OpenQA.Selenium.Edge;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        public Form1()
        {

            InitializeComponent();
            driver = new EdgeDriver(@"C:\Users\LEMAN\OneDrive\Dators\EKA\Progarmmaturas iztrades tehnologijas\");
            driver.Url = "https://www.ebay.com";
        }
        private void button1_Click(object sender,EventArgs e)
        { string SearchKey = textBox1.Text;
            IWebElement Searchbar = driver.FindElement(By.Id("gh-ac"));
            Searchbar.SendKeys(SearchKey);
            IWebElement button = driver.FindElement(By.Id("gh-btn"));
            button.Click();
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

