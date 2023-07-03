using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345 (Ignore Attribute Test)");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://web.archive.org/web/20180801193357/https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://web.archive.org/web/20180801193357/https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Quit();
            //driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            //Internet Explorer changed to Edge
            //IWebDriver driver = new InternetExplorerDriver();
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://web.archive.org/web/20180801193357/https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
