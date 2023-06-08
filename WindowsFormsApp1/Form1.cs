using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;
        private string currentSearchResultUrl;
        private string linkToSearchResultField;
        private string searchHistoryField;
        private string searchText;
        private string[] searchHistory;

        public Form1()
        {
            InitializeComponent();
            searchHistory = new string[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchText = textBox1.Text;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ebay.com/");
            IWebElement searchWindow = driver.FindElement(By.Id("gh-ac"));
            searchWindow.SendKeys(searchText);
            IWebElement searchButton = driver.FindElement(By.Id("gh-btn"));
            searchButton.Click();
            currentSearchResultUrl = driver.Url;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentSearchResultUrl = driver.Url;
            linkToSearchResultField = currentSearchResultUrl;
            AddToSearchHistory(currentSearchResultUrl);
            searchHistoryField = string.Join(", ", searchHistory);
            richTextBox1.AppendText(searchHistoryField + Environment.NewLine);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AddToSearchHistory(string searchUrl)
        {
            Array.Resize(ref searchHistory, searchHistory.Length + 1);
            searchHistory[searchHistory.Length - 1] = searchUrl;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.AppendText(currentSearchResultUrl + Environment.NewLine);
        }
    }
}
