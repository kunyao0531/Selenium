using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DefaultSelenium sel = new DefaultSelenium("localhost", 4444, "*Chrome", "http://kunyao.selenium/");

            sel.Start();
            sel.Open("http://kunyao.selenium/index.aspx");
            sel.Type("id=money", "1980");
            sel.Click("id=dosomething");
            Assert.AreEqual("九折 : 1782", sel.GetText("id=90"));
            Assert.AreEqual("八折 : 1584", sel.GetText("id=80"));
            Assert.AreEqual("七折 : 1386", sel.GetText("id=70"));
            Assert.AreEqual("六折 : 1188", sel.GetText("id=60"));
            sel.Stop();
        }
    }
}
