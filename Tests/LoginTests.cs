using Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Tests
{
    public class LoginTests : BaseTest
    {
        private LoginPage? loginPage;

        public LoginTests()
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver), "driver cannot be null.");
            }

            loginPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Theory]
        [InlineData("edge")]
        [InlineData("firefox")]
        [InlineData("chrome")]
        public void SetUpTest(string browser)
        {
            Assert.NotNull(driver);
            Assert.NotNull(loginPage);
        }

        [Fact]
        public void InvalidLogin_WithEmptyCredentials()
        {
            Assert.NotNull(loginPage);
            loginPage.EnterUsername(string.Empty);
            loginPage.EnterPassword(string.Empty);
            loginPage.ClickLoginButton();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'error')]")));

            string errorMessage = driver.FindElement(By.XPath("//div[contains(@class, 'error')]")).Text;
            Assert.Contains("Username is required", errorMessage);
        }

        [Fact]
        public void InvalidLogin_WithEmptyPasswordCredential()
        {
            Assert.NotNull(loginPage);
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword(string.Empty);
            loginPage.ClickLoginButton();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'error')]")));

            string errorMessage = driver.FindElement(By.XPath("//div[contains(@class, 'error')]")).Text;
            Assert.Contains("Password is required", errorMessage);
        }

        [Fact]
        public void ValidLogin_WithValidCredentials()
        {
            Assert.NotNull(loginPage);
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
            loginPage.ClickLoginButton();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'app_logo')]")));

            string title = driver.FindElement(By.XPath("//div[contains(@class, 'app_logo')]")).Text;
            Assert.Contains("Swag Labs", title);
        }
    }
}
