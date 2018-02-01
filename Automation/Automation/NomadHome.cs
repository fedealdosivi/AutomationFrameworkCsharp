using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    public class NomadHome
    {
        public void GoTo()
        {
            //Make sure to change the path to the corresponding
            var driver = new FirefoxDriver("C:/Users/federico.palomero/Documents/Projects/C#Automation/Automation/Automation");
            driver.Navigate().GoToUrl("https://nomadlist.com/");
        }

        public NomadCity SelectCity(int pos)
        {

            return new NomadCity();
        }
    }
}
