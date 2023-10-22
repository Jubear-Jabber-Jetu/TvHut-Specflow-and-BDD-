using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class SearchingForElectronicGoodsStepDefinitions
    {
        private IWebDriver driver;

        public SearchingForElectronicGoodsStepDefinitions()
            {
                driver = new ChromeDriver();
            }
        [Given(@"Go to Tv Hut official page")]
        public void GivenGoToTvHutOfficialPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
        }

        [When(@"Check search bar in avaliable")]
        public void WhenCheckSearchBarInAvaliable()
        {

            IWebElement searchInput = driver.FindElement(By.XPath("//input[@placeholder='Search...']"));
            Assert.IsNotNull(searchInput, "Search bar not found on the page");
        }

        [When(@"Search for Router")]
        public void WhenSearchForRouter()
        {
            string query = "Router";
            IWebElement searchInput2 = driver.FindElement(By.XPath("//input[@placeholder='Search...']"));
            searchInput2.Clear();
            searchInput2.SendKeys(query);
        }

        [Then(@"click search button")]
        public void ThenClickSearchButton()
        {
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@type='button']"));
            searchButton.Click();
        }

            [Then(@"Check that list is avaliable")]
        public void ThenCheckThatListIsAvaliable()
        {
            driver.FindElements(By.TagName("*")).All(e => !e.Displayed);
            driver.Close();
        }
    }
}
