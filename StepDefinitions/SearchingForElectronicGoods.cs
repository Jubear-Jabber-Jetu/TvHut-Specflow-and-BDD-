using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework; 

namespace TvHut.StepDefinitions
{
    [Binding]
    public class SearchingForElectronicGoods
    {
        private IWebDriver driver;

        public SearchingForElectronicGoods()
        {
            driver = new ChromeDriver();
        }

        [Given(@"the user is on the homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
        }

        [When(@"the user enters Router in the search bar")]
        public void WhenTheUserEntersInTheSearchBar()
        {
            string query = "Router";
            IWebElement searchInput2 = driver.FindElement(By.XPath("//input[@placeholder='Search...']"));
            searchInput2.Clear();
            searchInput2.SendKeys(query);
            
        }

        [When(@"clicks the search button")]
        public void WhenClicksTheSearchButton()
        { 
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@type='button']")); 
            searchButton.Click();
        }

        [Then(@"the user should see a list of Router")]
        public void ThenTheUserShouldSeeAListOfRouter()
        {
            driver.FindElements(By.TagName("*")).All(e => !e.Displayed);
            driver.Close();
        }
    }
}
