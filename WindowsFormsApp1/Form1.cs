using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
            //atver majaslapu un driveri
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(@"C:/Users/User/Downloads/chromedriver_win32/chromedriver.exe", options);
            //atver mājaslapu ebay.com
            driver.Url = "https://www.ebay.com/";

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //aizver browseri, beidz draivera darbu
            driver.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Pārlūkprogrammā izpilda back operāciju, atgriežoties ebay.com mājaslapā
            driver.Navigate().GoToUrl("https://www.ebay.com");

            //izdzēš iepriekšējo meklēšanas informāciju no search lauka,
            textBox1.Text = "";

            //izdzēš saiti uz meklēšanas rezultātu no link to search lauka
            textBox2.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //ieraksta ebay.com meklēšanas logā (meklēšanas loga elementa id ir "gh-ac")
            // informāciju no lauka search
            driver.FindElement(By.Id("gh-ac")).SendKeys(textBox1.Text);

            // noklikšķināt uz search
            driver.FindElement(By.Id("gh-btn")).Click();

            //pievieno saiti uz meklēšanas rezultātu link to search result laukā
            String saite1 = driver.Url;
            textBox2.Text = saite1;

            //pievieno saiti meklēšanas sarakstam Search history laukā
            richTextBox1.AppendText(saite1);
        }
    }
}
