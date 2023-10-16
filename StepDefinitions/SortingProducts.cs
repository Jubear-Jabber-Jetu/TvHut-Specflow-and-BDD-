using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class SortingProductsStepDefinitions
    {
        private IWebDriver driver;
        public SortingProductsStepDefinitions()
        {
            driver = new ChromeDriver();
        }
        [Given(@"the user is on the product listing page")]
        public void GivenTheUserIsOnTheProductListingPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/smart-tv");
        }

        [When(@"the user selects Price from the sort options")]
        public void WhenTheUserSelectsPriceFromTheSortOptions()
        {
            IWebElement priceSortOption = driver.FindElement(By.XPath("//a[contains(., 'Price')]"));
            priceSortOption.Click();
        }

        [Then(@"the products are displayed in ascending order of price")]
        public void ThenTheProductsAreDisplayedInAscendingOrderOfPrice()
        {
            IList<IWebElement> productPrices = driver.FindElements(By.ClassName("product-price"));
            List<decimal> prices = new List<decimal>();

            foreach (var productPrice in productPrices)
            {
                string priceText = productPrice.Text;
                prices.Add(decimal.Parse(priceText.Replace("৳", "").Trim()));
            }
            for (int i = 1; i < prices.Count; i++)
            {
                Assert.IsTrue(prices[i] >= prices[i - 1]);
            }
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
