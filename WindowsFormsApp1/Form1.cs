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
        private Stack<string> searchHistory = new Stack<string>(); // Store search history
        private Process browserProcess; // Store browser process information

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text; // Get text from search field

            // Create URL including search query
            string url = "https://www.ebay.com/sch/" + Uri.EscapeDataString(searchQuery);

            try
            {
                Process.Start(url); // Launch browser with search result URL
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Error launching browser: " + ex.Message);
            }

            // Add link to search result in the "link to search" field
            textBox2.Text = url;

            // Add link to search history in the "search history" field
            richTextBox1.Text += url + "";

            searchHistory.Push(searchQuery);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (searchHistory.Count > 0)
            {
                searchHistory.Pop(); // Remove the last search query from history

                // Update search history field with the remaining history
                richTextBox1.Text = string.Join("<br>", searchHistory.Select(query => "<a href='https://www.ebay.com/search?q=" + Uri.EscapeDataString(query) + "'>" + query + "</a>"));
                richTextBox1.Refresh();
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

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (browserProcess != null && !browserProcess.HasExited)
            {
                try
                {
                    browserProcess.CloseMainWindow(); // Attempt to close the browser window

                    if (!browserProcess.HasExited)
                    {
                        browserProcess.Close(); // Close the browser process
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error closing browser: " + ex.Message);
                }
            }

            // Close the current form (application)
            Application.Exit();
        }
    }
}