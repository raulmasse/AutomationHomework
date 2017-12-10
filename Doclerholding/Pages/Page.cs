using System;
using OpenQA.Selenium;

namespace Doclerholding.Pages
{
    public class Page
    {
        public IWebDriver driver { get; set; }

        public Page(IWebDriver driver)
        {
            this.driver = driver;
        }
     
        public String GetTitle => driver.Title;

        public IWebElement GetLogo => driver.FindElement(By.XPath("//img[@id='dh_logo']"));


        public void ClickHome() => driver.FindElement(By.Id("home")).Click();

        public void ClickForm() => driver.FindElement(By.Id("form")).Click();

        public void ClickError() => driver.FindElement(By.Id("error")).Click();

        public void ClickUI() => driver.FindElement(By.Id("site")).Click();

        public IWebElement IsHomeActive => driver.FindElement(By.XPath(".//*[@class='active']/a[@id='home']"));

        public IWebElement IsFormActive => driver.FindElement(By.XPath(".//*[@class='active']/a[@id='form']"));
       

    }
}
