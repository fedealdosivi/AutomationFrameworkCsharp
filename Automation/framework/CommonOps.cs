using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public abstract class CommonOps
    {
        protected IWebDriver GetDriver()
        {
            return Driver.Instance;
        }

        protected CommonOps Click(IWebElement element)
        {
            element.Click();
            return this;
        }

        protected CommonOps Submit(IWebElement element)
        {
            element.Submit();
            return this;
        }

        protected CommonOps Type(IWebElement element, String text)
        {
            element.SendKeys(text);
            return this;
        }

        protected String GetText(IWebElement element)
        {
            return element.Text;
        }
    }
}
