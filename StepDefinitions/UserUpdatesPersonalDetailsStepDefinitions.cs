using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class UserUpdatesPersonalDetailsStepDefinitions
    {
        private IWebDriver driver;

        public UserUpdatesPersonalDetailsStepDefinitions()
        {
            driver = new ChromeDriver();
        }
        [Given(@"Log in")]
        public void GivenLogIn()
        {

            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/index.php?route=account/login");
            driver.FindElement(By.XPath("//input[@id='input-email']")).SendKeys("jubearjabberjetu@gmail.com");
            driver.FindElement(By.XPath("//input[@id='input-password']")).SendKeys("266278");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Given(@"Click update information option")]
        public void GivenClickUpdateInformationOption()
        {

            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/index.php?route=account/edit");
            string expectedUrl = "https://www.tvhut.com.bd/index.php?route=account/edit";
            string currentUrl = driver.Url;
            Assert.AreEqual(expectedUrl, currentUrl);
        }

            [When(@"Enter First name")]
        public void WhenEnterFirstName()
        {
            IWebElement firstname = driver.FindElement(By.XPath("//input[@id='input-firstname']"));
            firstname.Clear();
            firstname.SendKeys("Abdul");
        }

        [When(@"Enter Last name")]
        public void WhenEnterLastName()
        {
            IWebElement lastname = driver.FindElement(By.XPath("//input[@id='input-lastname']"));
            lastname.Clear();
            lastname.SendKeys("Jabber");
        }

        [When(@"Enter email")]
        public void WhenEnterEmail()
        {
            IWebElement email = driver.FindElement(By.XPath("//input[@id='input-email']"));
            email.Clear();
            email.SendKeys("jubearjabberjetu@gmail.com");
        }

        [When(@"Enter phone number")]
        public void WhenEnterPhoneNumber()
        {
            IWebElement phone = driver.FindElement(By.XPath("//input[@id='input-telephone']"));
            phone.Clear();
            phone.SendKeys("01908857338");
        }

        [When(@"Click on submit")]
        public void WhenClickOnSubmit()
        {
            IWebElement submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            Assert.IsNotNull(submitButton, "Submit button not found on the page");
            if (submitButton != null)
            {
                submitButton.Click();
            }
        }

        [Then(@"Check that profile is updated")]
        public void ThenCheckThatProfileIsUpdated()
        {
            IWebElement errorMessage = driver.FindElement(By.XPath("//div[@class='alert alert-success alert-dismissible']"));
            Assert.IsTrue(errorMessage.Displayed);
            driver.Close();
        }
    }
}
