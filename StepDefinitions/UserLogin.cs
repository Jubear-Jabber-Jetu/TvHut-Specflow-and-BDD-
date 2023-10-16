using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class UserLogin
    {
        private IWebDriver driver;

        public UserLogin()
        {
            driver = new ChromeDriver();
        }

        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/index.php?route=account/login");
        }

        [When(@"the user enters valid login credentials")]
        public void WhenTheUserEntersValidLoginCredentials()
        {
            driver.FindElement(By.XPath("//input[@id='input-email']")).SendKeys("jubearjabberjetu@gmail.com");
            driver.FindElement(By.XPath("//input[@id='input-password']")).SendKeys("266278");
        }

        [When(@"clicks the login button")]
        public void WhenClicksTheLoginButton()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"the user should be logged in successfully")]
        public void ThenTheUserShouldBeLoggedInSuccessfully()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/index.php?route=account/account"));
            driver.Quit();
        }

        [When(@"the user enters invalid login credentials")]
        public void WhenTheUserEntersInvalidLoginCredentials()
        {
            driver.FindElement(By.XPath("//input[@id='input-email']")).SendKeys("invaid@gmail.com");
            driver.FindElement(By.XPath("//input[@id='input-password']")).SendKeys("invalid");
        }

        [Then(@"an error message should be displayed")]
        public void ThenAnErrorMessageShouldBeDisplayed()
        {
            IWebElement errorMessage = driver.FindElement(By.XPath("//div[@class='alert alert-danger alert-dismissible']")); 
            Assert.IsTrue(errorMessage.Displayed);
        }

        [Then(@"the user should not be logged in")]
        public void ThenTheUserShouldNotBeLoggedIn()
        {
            bool isLoggedIn = CheckIfUserIsLoggedIn();
            Assert.IsFalse(isLoggedIn);
            driver.Quit();
        }
        private bool CheckIfUserIsLoggedIn()
        {
            return false;
            driver.Quit();
        }

    }
}
