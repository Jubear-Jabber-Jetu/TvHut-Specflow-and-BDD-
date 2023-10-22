using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class WebPageVerificationStepDefinitions
    {
        private IWebDriver driver;
        private object pageTitle;
        private IWebElement searchBar;

        public WebPageVerificationStepDefinitions()
        {
            driver = new ChromeDriver();
        }
        [Given(@"Go to Tv Hut page")]
        public void GivenGoToTvHutPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/");
        }

        [Then(@"Check account button is available")]
        public void ThenCheckAccountButtonIsAvailable()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            bool isAccountButtonAvailable = wait.Until(driver =>
            {
                return IsElementAvailable(driver, By.XPath("//li[@class='menu-item top-menu-item top-menu-item-10']//a[@href='javascript:open_login_popup()']"));
            });

            Assert.IsTrue(isAccountButtonAvailable, "Account button is not available on the page");
            driver.Quit();

        }

        private bool IsElementAvailable(IWebDriver driver, By by)
        {
            try
            {
                var element = driver.FindElement(by);
                return element != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        [Then(@"Check title is not null and as expected")]
        public void ThenCheckTitleIsNotNullAndAsExpected()
        {

            pageTitle = driver.Title;
            Assert.IsNotNull(pageTitle, "Page title is null");
            Assert.IsFalse(string.IsNullOrWhiteSpace((string?)pageTitle), "Page title is empty or whitespace");

            if (!string.IsNullOrWhiteSpace((string?)pageTitle))
            {
                Console.WriteLine($"Page Title: {pageTitle}");
                driver.Quit();
            }

        }

        [Then(@"Check search bar is available")]
        public void ThenCheckSearchBarIsAvailable()
        {
            searchBar = driver.FindElement(By.XPath("//input[@placeholder='Search...']"));
            driver.Quit();
        }

        [Then(@"I should see search bar")]
        public void ThenIShouldSeeSearchBar()
        {
            Assert.IsNotNull(searchBar, "Search bar not found");
        }
        
    }
    
}
