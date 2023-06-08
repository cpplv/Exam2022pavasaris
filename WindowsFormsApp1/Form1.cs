using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Stack<string> searchHistory = new Stack<string>(); 
        private Process browserProcess; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text;

            string url = "https://www.ebay.com/sch/" + Uri.EscapeDataString(searchQuery);

            try
            {
                Process.Start(url); 
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Error launching browser: " + ex.Message);
            }

            textBox2.Text = url;

      
            richTextBox1.Text += url + "\n";

            searchHistory.Push(searchQuery);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (searchHistory.Count > 0)
            {
                searchHistory.Pop(); 

             
                richTextBox1.Text = string.Join("<br>", searchHistory.Select(query => "https://www.ebay.com/search?q=" + query));

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (browserProcess != null && !browserProcess.HasExited)
            {
                try
                {
                    browserProcess.CloseMainWindow();

                    if (!browserProcess.HasExited)
                    {
                        browserProcess.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error closing browser: " + ex.Message);
                }
            }

      
            Application.Exit();
        }
    }
}