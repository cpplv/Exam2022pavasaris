using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Ebay;

namespace ClassLibrary1.Tests
{
    internal class Tests
    {
        [Test]
        public void Test1_field()
        {
            string id = "gh-ac";

            Form1 form1 = new Form1();

            Assert.IsTrue(form1.Validate(id));
        }

        [Test]
        public void Test2_search()
        {
            string id = "gh-btn";

            Form1 form1 = new Form1();

            Assert.IsTrue(form1.Validate(id));
        }

    }
}
