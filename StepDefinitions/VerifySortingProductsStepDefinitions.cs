using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TvHut.StepDefinitions
{
    [Binding]
    public class VerifySortingProductsStepDefinitions
    {
        private IWebDriver driver;

        public object ExpectedConditions { get; private set; }
        public VerifySortingProductsStepDefinitions()
        {
            driver = new ChromeDriver();
        }
        [Given(@"Navigate to product listing page")]
        public void GivenNavigateToProductListingPage()
        {
            driver.Navigate().GoToUrl("https://www.tvhut.com.bd/smart-tv");
        }

        [When(@"Click on Price \( High > Low \)")]
        public void WhenClickOnPriceHighLow()
        {
            IWebElement sortByDropdown = driver.FindElement(By.XPath("//select[@id='input-sort']"));
            IWebElement priceHighToLowOption = sortByDropdown.FindElement(By.XPath(".//option[@value='https://www.tvhut.com.bd/smart-tv?sort=p.price&order=DESC']"));
            priceHighToLowOption.Click();
        }

        [Then(@"Check that displayed options are organized from high to low price")]
        public void ThenCheckThatDisplayedOptionsAreOrganizedFromHighToLowPrice()
        {
            IList<IWebElement> productPrices = driver.FindElements(By.ClassName("product-price"));
            List<decimal> prices = new List<decimal>();

            foreach (var productPrice in productPrices)
            {
                string priceText = productPrice.Text;
                prices.Add(decimal.Parse(priceText.Replace("?", "").Trim()));
            }

            for (int i = 1; i < prices.Count; i++)
            {
                Assert.IsTrue(prices[i] >= prices[i - 1], "Products are not displayed in ascending order of price.");
            }
        }

        [Then(@"Click on Name \( A - Z \)")]
        public void ThenClickOnNameA_Z()
        {
            IWebElement sortByDropdown2 = driver.FindElement(By.XPath("//select[@id='input-sort']"));
            IWebElement name = sortByDropdown2.FindElement(By.XPath("//option[@value='https://www.tvhut.com.bd/smart-tv?sort=pd.name&order=ASC']"));

            name.Click();
        }

        [Then(@"Check that displayed options are organized in ascending order")]
        public void ThenCheckThatDisplayedOptionsAreOrganizedInAscendingOrder()
        {
            List<IWebElement> productNames = driver.FindElements(By.CssSelector(".product-name")).ToList();

            for (int i = 0; i < productNames.Count - 1; i++)
            {
                string productName1 = productNames[i].Text;
                string productName2 = productNames[i + 1].Text;
                Assert.IsTrue(string.Compare(productName1, productName2) <= 0);
            }
        }

        [Then(@"Click on Rate \( Highest \)")]
        public void ThenClickOnRateHighest()
        {
            IWebElement sortByDropdown3 = driver.FindElement(By.XPath("//select[@id='input-sort']"));
            IWebElement rate = sortByDropdown3.FindElement(By.XPath("//option[@value='https://www.tvhut.com.bd/smart-tv?sort=rating&order=DESC']"));

            rate.Click();
        }

        [Then(@"Check that displayed options are  the highest rated order")]
        public void ThenCheckThatDisplayedOptionsAreTheHighestRatedOrder()
        {
            // Get the list of product ratings and store them in a list
            IList<IWebElement> productRatings = driver.FindElements(By.CssSelector(".product-rating"));
            List<decimal> ratings = new List<decimal>();

            foreach (var productRating in productRatings)
            {
                string ratingText = productRating.Text;
                decimal rating = decimal.Parse(ratingText.Split(':')[1].Trim());
                ratings.Add(rating);
            }

            for (int i = 1; i < ratings.Count; i++)
            {
                Assert.IsTrue(ratings[i] <= ratings[i - 1], "Products are not sorted by rating from highest to lowest.");
            }
            driver.Quit();
        }
    }
}
