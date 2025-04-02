using OpenQA.Selenium;
using Utils;

namespace Tests
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver driver;
        private DriverManager driverManager;

        public BaseTest()
        {
            driverManager = new DriverManager();
            driver = driverManager.InitializeDriver();
        }

        public void Dispose()
        {
            driverManager.QuitDriver();
        }
    }
}
