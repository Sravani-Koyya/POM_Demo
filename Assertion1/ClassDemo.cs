using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assertion1
{
    class Assert_Demo_1
    {
        Browser_open brow = new Browser_open();
        String test_url = "https://www.google.com/";
        String test_url1 = "https://www.facebook.com/";

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_asserturl()
        {
            brow.Goto(test_url);

            System.Threading.Thread.Sleep(4000);

            String actual_url = brow.Geturl;
            Console.WriteLine("url " + actual_url);

            // Raise an assert if the URL's do not match
            Assert.That(actual_url, Is.EqualTo(test_url));

            Console.WriteLine("Test Passed");

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }
        [Test]
        public void test_asserturl1()
        {
            brow.Goto(test_url1);

            System.Threading.Thread.Sleep(4000);

            String actual_url1 = brow.Geturl;
            Console.WriteLine("url " + actual_url1);

            // Raise an assert if the URL's do not match
            Assert.That(actual_url1, Is.EqualTo(test_url));

            Console.WriteLine("Test Passed");

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}
