using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace framework
{
    public class GoogleResults
    {
        WebDriverWait wait= new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));

        public GoogleImages SelectImages()
        {
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "hdtb-msb");
            var imagesTab=Driver.Instance.FindElement(By.CssSelector("#hdtb-msb-vis > div:nth-child(2) > a"));
            imagesTab.Click();
            return new GoogleImages();
        }

        public bool VerifyResults()
        {
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "rso");
            var results=Driver.Instance.FindElement(By.Id("rso"));
            return results.Displayed;
        }

        public GoogleResults SelectSettings()
        {
            var settings = wait.Until(d => d.FindElement(By.Id("hdtb-tls")));
            settings.Click();
            return this;
        }
    }
}