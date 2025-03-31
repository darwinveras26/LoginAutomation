using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Pages
{
    [CollectionDefinition("ParallelTests", DisableParallelization = false)]
    public class ParallelTestCollection { }

    [Collection("ParallelTests")]
    public class BaseTest : IDisposable
    {
        protected IWebDriver? driver;

        public BaseTest()
        {
            string browser = Environment.GetEnvironmentVariable("BROWSER") ?? "chrome";
            SetUp(browser);
            driver.Manage().Window.Maximize();
        }

        public void SetUp(string browser)
        {
            switch (browser.ToLower())
            {
                case "edge":
                    driver = new EdgeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                default:
                    throw new ArgumentException("Incorrect browser");
            }
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
