using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace framework
{
    public class GoogleResults : CommonOps
    {
        WebDriverWait wait= new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));

        public GoogleImages SelectImages()
        {
            var imagesTab = wait.Until(d => d.FindElement(By.CssSelector("#hdtb-msb-vis > div:nth-child(3) > a")));
            Click(imagesTab);
            return new GoogleImages();
        }

        public bool VerifyResults()
        {
            var results= wait.Until(d => d.FindElement(By.Id("rso")));
            return results.Displayed;
        }

        public GoogleResults SelectSettings()
        {
            var settings = wait.Until(d => d.FindElement(By.Id("hdtb-tls")));
            Click(settings);
            return this;
        }
    }
}