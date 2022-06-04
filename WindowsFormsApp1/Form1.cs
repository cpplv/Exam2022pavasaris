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
        List<string> history;
        public Form1()
        {
            
            InitializeComponent();
            driver = new ChromeDriver(@"D:\Privatie faili\EKA\Izstrade\chromedriver_win32");
            driver.Url = "https://www.ebay.com/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            string serchKey = textBox1.Text;

            IWebElement serchField = driver.FindElement(By.CssSelector("#gh-ac"));
            // serchField.SendKeys("");
            serchField.Clear();
            serchField.SendKeys(serchKey);
            driver.FindElement(By.CssSelector("#gh-btn")).Click();
            textBox2.Text = driver.Url;
            
            richTextBox1.AppendText(driver.Url);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Close();
        }
        
    }
}
