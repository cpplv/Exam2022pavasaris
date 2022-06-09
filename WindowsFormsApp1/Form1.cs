using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver _driver;

        public Form1()
        {
            InitializeComponent();
            var options = new ChromeOptions();
            this._driver = new ChromeDriver(@"C:\Users\KristineR\Documents\EKA\Programmaturas izstrades teh\chromedriver_win32", options);
            this._driver.Url = "https://www.ebay.com/";
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            this._driver.Url = "https://www.ebay.com/";

            if (IsInputValid())
            {
                try
                {
                    IWebElement search = this._driver.FindElement(By.Id("gh-ac"));
                    search.Clear();
                    search.SendKeys(textBox1.Text);
                    IWebElement buttonToClick = this._driver.FindElement(By.Id("gh-btn"));
                    buttonToClick.Click();
                    textBox2.Text = this._driver.Url;
                    richTextBox1.AppendText(textBox2.Text + "\n");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._driver.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {         
            this._driver.Navigate().Back();
            textBox1.Clear();
            textBox2.Clear();
        }

        private bool IsInputValid()
        {
            bool isValid = !string.IsNullOrEmpty(textBox1.Text);

            if (!isValid)
            {
                MessageBox.Show("Ievades lauks nav aizpildīts!");
            }

            return isValid;
        }
    }
}
