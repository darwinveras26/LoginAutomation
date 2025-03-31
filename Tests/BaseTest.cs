using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Pages
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver driver;

        public BaseTest()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
