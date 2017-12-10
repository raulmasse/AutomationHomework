using OpenQA.Selenium;
using System;

namespace Doclerholding.Pages
{
    internal class HomePage: Page
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public String H1tag => driver.FindElement(By.XPath("/html/body/div/div[1]/h1")).Text;

        public String Ptag => driver.FindElement(By.XPath("/html/body/div/div[1]/p")).Text;
    }
}