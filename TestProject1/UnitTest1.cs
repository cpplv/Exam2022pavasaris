using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Test_SearchButtonExists()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            Button searchButton = form.Controls["button1"] as Button;

            // Assert
            Assert.IsNotNull(searchButton, "Element with id 'button1' does not exist.");
        }
    }
}