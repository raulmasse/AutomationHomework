using OpenQA.Selenium;
using System;

namespace Doclerholding.Pages
{
    internal class FormPage: Page
    {

        public FormPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public bool InputBoxVisible => driver.FindElement(By.Id("hello-input")).Displayed;

        public bool SubmitButtonVisible => driver.FindElement(By.Id("hello-submit")).Displayed;

        public void enterName(String name)
        {
            driver.FindElement(By.Id("hello-input")).Clear();
            driver.FindElement(By.Id("hello-input")).SendKeys(name);
        }

        public void SubmitButtonClick() => driver.FindElement(By.Id("hello-submit")).Click();
    }
}