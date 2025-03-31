using OpenQA.Selenium;

namespace Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver), "driver can not be null");
            }

            this.driver = driver;
        }

        public void FindLocatorAndSendKeys(By locator, string message)
        {
            driver.FindElement(locator).SendKeys(message);
        }

        public void FindLocatorAndClick(By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}