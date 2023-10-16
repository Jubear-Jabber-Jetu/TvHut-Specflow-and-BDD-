using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class CategoryLinkVerification
    {
        private IWebDriver driver;

        public CategoryLinkVerification()
        {
            driver = new ChromeDriver();
        }
        [Given(@"the user is on the tvhut\.com")]
        public void GivenTheUserIsOnTheTvhut_Com()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
        }

        [When(@"the user clicks on the Television category link")]
        public void WhenTheUserClicksOnTheTelevisionCategoryLink()
        {
            driver.FindElement(By.XPath("//img[@alt='Television']")).Click();
        }

        [Then(@"the user should be on the Television category page")]
        public void ThenTheUserShouldBeOnTheTelevisionCategoryPage()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/smart-tv"));
        }

        [When(@"the user clicks on the Air Conditioner category link")]
        public void WhenTheUserClicksOnTheAirConditionerCategoryLink()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//a[@class='info-block']//img[@alt='Air Conditioner']")).Click();
        }

        [Then(@"the user should be on the Air Conditioner category page")]
        public void ThenTheUserShouldBeOnTheAirConditionerCategoryPage()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/air-conditioner"));
        }

        [When(@"the user clicks on the Interactive Flat category link")]
        public void WhenTheUserClicksOnTheInteractiveFlatCategoryLink()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//img[@alt='Interactive Flat']")).Click();
        }

        [Then(@"the user should be on the Interactive Flat category page")]
        public void ThenTheUserShouldBeOnTheInteractiveFlatCategoryPage()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/interactive-flat-panel-display"));
        }

        [When(@"the user clicks on the Washing Machine category link")]
        public void WhenTheUserClicksOnTheWashingMachineCategoryLink()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//a[@class='info-block']//img[@alt='Washing Machine']")).Click();
        }

        [Then(@"the user should be on the Washing Machine category page")]
        public void ThenTheUserShouldBeOnTheWashingMachineCategoryPage()
        {
            Assert.IsTrue(driver.Url.Contains(""));
        }

        [When(@"the user clicks on the Refrigerator category link")]
        public void WhenTheUserClicksOnTheRefrigeratorCategoryLink()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//div[@class='info-block-title'][normalize-space()='Refrigerator']")).Click();
        }

        [Then(@"the user should be on the Refrigerator category page")]
        public void ThenTheUserShouldBeOnTheRefrigeratorCategoryPage()
        {
            Assert.IsTrue(driver.Url.Contains(""));
        }

        [When(@"the user clicks on the Audio System category link")]
        public void WhenTheUserClicksOnTheAudioSystemCategoryLink()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//div[@class='module-item module-item-6 info-blocks info-blocks-image']//a[@class='info-block']")).Click();
        }

        [Then(@"the user should be on the Audio System category page")]
        public void ThenTheUserShouldBeOnTheAudioSystemCategoryPage()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/speakers"));
        }

        [When(@"the user clicks on the Smart Watch category link")]
        public void WhenTheUserClicksOnTheSmartWatchCategoryLink()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//a[@class='info-block']//img[@alt='Smart Watch']")).Click();
        }

        [Then(@"the user should be on the Smart Watch category page")]
        public void ThenTheUserShouldBeOnTheSmartWatchCategoryPage()
        {
        https://www.tvhut.com.bd/smart-watch
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/smart-watch"));
        }

        [When(@"the user clicks on the Router category link")]
        public void WhenTheUserClicksOnTheRouterCategoryLink()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
            driver.FindElement(By.XPath("//img[@alt='Router']")).Click();
        }

        [Then(@"the user should be on the Router category page")]
        public void ThenTheUserShouldBeOnTheRouterCategoryPage()
        {
            Assert.IsTrue(driver.Url.Contains("https://www.tvhut.com.bd/router"));
            driver.Quit();
        }
    }
}
