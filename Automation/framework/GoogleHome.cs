using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class GoogleHome
    {
        WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));

        public GoogleHome Go()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.google.com");
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "lst-ib");
            return this;
        }

        public GoogleResults Search(string v)
        {
            var googleImg = Driver.Instance.FindElement(By.Id("lga"));
            var searchInput = Driver.Instance.FindElement(By.Name("q"));
            searchInput.SendKeys(v);
            searchInput.Submit();
            wait.Until(ExpectedConditions.StalenessOf(googleImg));
            return new GoogleResults();
        }
    }
}
