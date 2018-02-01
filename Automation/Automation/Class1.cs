using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    public class Class1
    {
        public void goToGoogle()
        {
            var driver = new FirefoxDriver("C:/Users/federico.palomero/Documents/Projects/C#Automation/Automation/Automation");
            driver.Navigate().GoToUrl("http://google.com");
        }
    }
}
