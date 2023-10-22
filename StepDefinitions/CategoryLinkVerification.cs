using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class CategoryLinkVerificationStepDefinitions
    {
        private IWebDriver driver;

        public CategoryLinkVerificationStepDefinitions()
        {
            driver = new ChromeDriver();
        }
        [Given(@"Navigate to Tv Hut official page")]
        public void GivenNavigateToTvHutOfficialPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
        }

        [When(@"Click on Television")]
        public void WhenClickOnTelevision()
        {
            driver.FindElement(By.XPath("//img[@alt='Television']")).Click();
        }

        [Then(@"Check that Television is avaliable")]
        public void ThenCheckThatTelevisionIsAvaliable()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/smart-tv"));
        }

        [When(@"Click on the Air Conditioner")]
        public void WhenClickOnTheAirConditioner()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//a[@class='info-block']//img[@alt='Air Conditioner']")).Click();
        }

        [Then(@"Check that Air conditioner is avaliable")]
        public void ThenCheckThatAirConditionerIsAvaliable()
        {

            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/air-conditioner"));
        }

        [When(@"Click on the Interactive Flat")]
        public void WhenClickOnTheInteractiveFlat()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//img[@alt='Interactive Flat']")).Click();
        }

        [Then(@"Check that Interactive Flat is avaliable")]
        public void ThenCheckThatInteractiveFlatIsAvaliable()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/interactive-flat-panel-display"));
        }

        [When(@"Click on the Washing Machine")]
        public void WhenClickOnTheWashingMachine()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//a[@class='info-block']//img[@alt='Washing Machine']")).Click();
        }


        [Then(@"Check that Washing Machine is avaliable")]
        public void ThenCheckThatWashingMachineIsAvaliable()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/washing-machine"));
        }


        [When(@"Click on the Refrigerator")]
        public void WhenClickOnTheRefrigerator()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//div[@class='info-block-title'][normalize-space()='Refrigerator']")).Click();
        }

        [Then(@"Check that Refrigerator is avaliable")]
        public void ThenCheckThatRefrigeratorIsAvaliable()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/refrigerator"));
        }

        [When(@"Click on the Audio System")]
        public void WhenClickOnTheAudioSystem()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//div[@class='module-item module-item-6 info-blocks info-blocks-image']//a[@class='info-block']")).Click();
        }

        [Then(@"Check that Audio System is avaliable")]
        public void ThenCheckThatAudioSystemIsAvaliable()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/speakers"));
        }

        [When(@"Click on the Smart Watch")]
        public void WhenClickOnTheSmartWatch()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//a[@class='info-block']//img[@alt='Smart Watch']")).Click();
        }

        [Then(@"Check that Smart Watch is avaliable")]
        public void ThenCheckThatSmartWatchIsAvaliable()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/smart-watch"));
        }
        [When(@"Click on the Router")]
        public void WhenClickOnTheRouter()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//img[@alt='Router']")).Click();
        }

        [Then(@"Check that Router is avaliable")]
        public void ThenCheckThatRouterIsAvaliable()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/router"));
            driver.Quit();
        }
    }
}
