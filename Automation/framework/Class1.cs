using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class Class1
    {
        IWebDriver driver;

        public void Go()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        public void quit()
        {
            driver.Close();
        }
    }
}
