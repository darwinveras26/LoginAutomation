using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        private readonly WebDriverWait wait;

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Default wait time
        }

        // Generic method to find an element
        protected IWebElement FindElement(By locator)
        {
            return wait.Until(ExpectedConditions.ElementExists(locator));
        }

        // Generic method to click an element
        protected void Click(By locator)
        {
            FindElement(locator).Click();
        }

        // Generic method to enter text in a field
        protected void EnterText(By locator, string text)
        {
            var element = FindElement(locator);
            element.Clear(); // Ensure the field is empty before entering text
            element.SendKeys(text);
        }

        // Wait for an element to be visible
        protected void WaitForElementToBeVisible(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
