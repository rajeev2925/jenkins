using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace jenkins
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sample()
        {
            IWebDriver driver=new ChromeDriver();
            Thread.Sleep(2000);
            driver.Close(); 
        }
    }
}
