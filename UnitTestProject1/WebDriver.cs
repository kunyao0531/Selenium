using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for WebDriver
    /// </summary>
    [TestClass]
    public class Example
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:23618/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheExampleTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/index.aspx");
            driver.FindElement(By.Id("money")).Clear();
            driver.FindElement(By.Id("money")).SendKeys("1980");
            driver.FindElement(By.Id("money")).Clear();
            driver.FindElement(By.Id("money")).SendKeys("1980");
            driver.FindElement(By.Id("dosomething")).Click();
            driver.FindElement(By.Id("dosomething")).Click();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("九折 : 1782", driver.FindElement(By.Id("90")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
