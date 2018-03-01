using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            Instance = new ChromeDriver(options);

            //FirefoxOptions optionFirefox = new FirefoxOptions();
            //optionFirefox.AddArguments("--start-maximized");
            //Instance = new FirefoxDriver();
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static GoogleHome GetGoogleInitialPage()
        {
            Instance.Navigate().GoToUrl("https://www.google.com");
            return new GoogleHome();
        }
    }
}
