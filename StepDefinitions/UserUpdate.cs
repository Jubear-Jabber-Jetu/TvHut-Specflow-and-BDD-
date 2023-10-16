using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class UserUpdate
    {
        private IWebDriver driver;

        public UserUpdate()
        {
            driver = new ChromeDriver();
        }
        [Given(@"the user is logged in")]
        public void GivenTheUserIsLoggedIn()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/index.php?route=account/login");
            driver.FindElement(By.XPath("//input[@id='input-email']")).SendKeys("jubearjabberjetu@gmail.com");
            driver.FindElement(By.XPath("//input[@id='input-password']")).SendKeys("266278");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Given(@"the user is on the account page")]
        public void GivenTheUserIsOnTheAccountPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/index.php?route=account/edit");
        }

        [When(@"the user enters first name in the field")]
        public void WhenTheUserEntersFirstNameInTheField()
        {
           IWebElement firstname = driver.FindElement(By.XPath("//input[@id='input-firstname']"));
            firstname.Clear();
            firstname.SendKeys("Abdul");
        }

        [When(@"the user enters last name in the field")]
        public void WhenTheUserEntersLastNameInTheField()
        {
            IWebElement lastname = driver.FindElement(By.XPath("//input[@id='input-lastname']"));
            lastname.Clear();
            lastname.SendKeys("Jabber");
        }

        [When(@"the user enters email in the field")]
        public void WhenTheUserEntersEmailInTheField()
        {
            IWebElement email = driver.FindElement(By.XPath("//input[@id='input-email']"));
            email.Clear();
            email.SendKeys("jubearjabberjetu@gmail.com");
        }

        [When(@"the user enters phone number in the field")]
        public void WhenTheUserEntersPhoneNumberInTheField()
        {
            IWebElement phone = driver.FindElement(By.XPath("//input[@id='input-telephone']"));
            phone.Clear();
            phone.SendKeys("01908857338");
            
        }

        [When(@"the user clicks the submit button")]
        public void WhenTheUserClicksTheSubmitButton()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"the user should be able to update the profile page")]
        public void ThenTheUserShouldBeAbleToUpdateTheProfilePage()
        {
            IWebElement errorMessage = driver.FindElement(By.XPath("//div[@class='alert alert-success alert-dismissible']"));
            Assert.IsTrue(errorMessage.Displayed);
            driver.Close();
        }
    }
}
