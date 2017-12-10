using OpenQA.Selenium;
using System;

namespace Doclerholding.Pages
{
    internal class HelloPage : Page
    {
        public HelloPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public String HelloText => driver.FindElement(By.Id("hello-text")).Text;
    }
}