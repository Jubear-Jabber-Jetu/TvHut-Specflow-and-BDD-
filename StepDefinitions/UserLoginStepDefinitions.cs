using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class UserLoginStepDefinitions
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void Cleanup()
        {
            driver.Quit();
        }

        [Given(@"Navigate to Login page")]
        public void GivenNavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/index.php?route=account/login");
        }

        [When(@"Enter email in the email fied")]
        public void WhenEnterEmailInTheEmailFied()
        {
            driver.FindElement(By.Id("input-email")).SendKeys("jubearjabberjetu@gmail.com");
        }

        [When(@"Enter password in the password field")]
        public void WhenEnterPasswordInThePasswordField()
        {
            driver.FindElement(By.Id("input-password")).SendKeys("266278");
        }

        [Then(@"Click Login button")]
        public void ThenClickLoginButton()
        {
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        [Then(@"Check login status")]
        public void ThenCheckLoginStatus()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/index.php?route=account/account"));
        }
    }
}
