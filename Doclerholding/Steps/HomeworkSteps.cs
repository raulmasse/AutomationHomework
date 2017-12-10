using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Doclerholding.Pages;

namespace Doclerholding.DH_QA_Homework.DH_QA_Homework.Steps
{
    [Binding]
    public class HomeworkSteps
    {

        public IWebDriver driver;
        HomePage homePage;
        FormPage formPage;
        HelloPage helloPage;
        Page parentpage;


        [Given(@"I'm on the duodecad site")]
        public void GivenIMOnTheDuodecadSite()
        {
            this.driver = new ChromeDriver();
            this.driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
            homePage = new HomePage(driver);
        }
        
        [Given(@"I'm on the Form page")]
        public void GivenIMOnTheFormPage()
        {
            this.driver = new ChromeDriver();
            this.driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
            formPage = new FormPage(driver);
        }

        [When(@"I click on the Home button")]
        public void WhenIClickOnTheHomeButton()
        {
            parentpage = new Page(driver);
            parentpage.ClickHome();
        }

        [When(@"I click on the Form button")]
        public void WhenIClickOnTheFormButton()
        {
            parentpage = new Page(driver);
            parentpage.ClickForm();
        }
        
        [When(@"I click on the Error Button")]
        public void WhenIClickOnTheErrorButton()
        {
            parentpage = new Page(driver);
            parentpage.ClickError();
        }
        
        [When(@"I click on the UI Testing button")]
        public void WhenIClickOnTheUITestingButton()
        {
            parentpage = new Page(driver);
            parentpage.ClickUI();
        }
        
        [When(@"I type (.*) and click submit")]
        public void WhenITypeNameAndClickSubmit(String name)
        {
            formPage = new FormPage(driver);
            formPage.enterName(name);
            formPage.SubmitButtonClick();
        }
        
        [Then(@"I should get navigated to the Home page")]
        public void ThenIShouldGetNavigatedToTheHomePage()
        {
            Assert.AreEqual(driver.Url, "http://uitest.duodecadits.com/");
        }
        
        [Then(@"Home button should turn to active status")]
        public void ThenHomeButtonShouldTurnToActiveStatus()
        {
            parentpage = new Page(driver);
            Assert.NotNull(parentpage.IsHomeActive);
        }

        [Then(@"The Title should be UI Testing Site")]
        public void ThenTheTitleShouldBe()
        {
            parentpage = new Page(driver);
            Assert.AreEqual("UI Testing Site", parentpage.GetTitle);
        }
        
        [Then(@"The Company Logo should be visible")]
        public void ThenTheCompanyLogoShouldBeVisible()
        {
            parentpage = new Page(driver);
            Assert.NotNull(parentpage.GetLogo);
        }

        [Then(@"Welcome to the Docler Holding QA Department should be visible in h")]
        public void ThenShouldBeVisibleIn()
        {
            homePage = new HomePage(driver);
            Assert.AreEqual("Welcome to the Docler Holding QA Department", homePage.H1tag);
        }

        [Then(@"This site is dedicated to perform some exercises and demonstrate automated web testing in p")]
        public void ThenIn()
        {
            homePage = new HomePage(driver);
            Assert.AreEqual("This site is dedicated to perform some exercises and demonstrate automated web testing.", homePage.Ptag);
        }
        
        [Then(@"I should get navigated to the Form page")]
        public void ThenIShouldGetNavigatedToTheFormPage()
        {
            Assert.AreEqual(driver.Url, "http://uitest.duodecadits.com/form.html");
        }
        
        [Then(@"Form button should turn to active status")]
        public void ThenFormButtonShouldTurnToActiveStatus()
        {
            parentpage = new Page(driver);
            Assert.NotNull(parentpage.IsFormActive);
        }
        
        [Then(@"a form should be visible with one input box and one submit button")]
        public void ThenAFormShouldBeVisibleWithOneInputBoxAndOneSubmitButton()
        {
            formPage = new FormPage(driver);
            Assert.IsTrue(formPage.InputBoxVisible);
            Assert.IsTrue(formPage.SubmitButtonVisible);
        }
        
        [Then(@"I should get a (.*) HTTP response code")]
        public void ThenIShouldGetAHTTPResponseCode(int p0)
        {
            Assert.AreEqual(driver.Url, "http://uitest.duodecadits.com/error");
        }
        
        [Then(@"should get redirected to the Hello page")]
        public void ThenShouldGetRedirectedToTheHelloPage()
        {
            StringAssert.Contains("http://uitest.duodecadits.com/hello.html", driver.Url);
        }
        
        [Then(@"Hello (.*) should appear")]
        public void ThenHelloJohnShouldAppear(String name)
        {
            helloPage = new HelloPage(driver);
            StringAssert.Contains(name, helloPage.HelloText);            
        }
    }
}
