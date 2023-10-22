using OpenQA.Selenium;

namespace TvHut.StepDefinitions
{
    internal class SelectElement
    {
        private IWebElement sortByDropdown;

        public SelectElement(IWebElement sortByDropdown)
        {
            this.sortByDropdown = sortByDropdown;
        }

        public object SelectedOption { get; internal set; }

        internal void SelectByText(string v)
        {
            throw new NotImplementedException();
        }

        internal void SelectByValue(string v)
        {
            throw new NotImplementedException();
        }
    }
}