using Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    public class LoginTests : BaseTest
    {
        private LoginPage loginPage;

        public LoginTests()
            : base()
        {
            loginPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Fact]
        public void InvalidLogin_WithEmptyCredentials()
        {
            try
            {
                loginPage.EnterUsername(string.Empty);
                loginPage.EnterPassword(string.Empty);
                loginPage.ClickLoginButton();

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'error')]")));

                string errorMessage = driver.FindElement(By.XPath("//div[contains(@class, 'error')]")).Text;
                Assert.Contains("Username is required", errorMessage);
            }
            catch (WebDriverException ex)
            {
                Console.WriteLine($"WebDriver error: {ex.Message}");
                Assert.Fail("Test failed due to WebDriver issue.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                Assert.Fail("Test failed due to an unexpected error.");
            }
        }

        [Fact]
        public void InvalidLogin_WithEmptyPasswordCredential()
        {
            try
            {
                loginPage.EnterUsername("standard_user");
                loginPage.EnterPassword(string.Empty);
                loginPage.ClickLoginButton();

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'error')]")));

                string errorMessage = driver.FindElement(By.XPath("//div[contains(@class, 'error')]")).Text;
                Assert.Contains("Password is required", errorMessage);
            }
            catch (WebDriverException ex)
            {
                Console.WriteLine($"WebDriver error: {ex.Message}");
                Assert.Fail("Test failed due to WebDriver issue.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                Assert.Fail("Test failed due to an unexpected error.");
            }
        }

        [Fact]
        public void ValidLogin_WithValidCredentials()
        {
            try
            {
                loginPage.EnterUsername("standard_user");
                loginPage.EnterPassword("secret_sauce");
                loginPage.ClickLoginButton();

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'app_logo')]")));

                string title = driver.FindElement(By.XPath("//div[contains(@class, 'app_logo')]")).Text;
                Assert.Contains("Swag Labs", title);
            }
            catch (WebDriverException ex)
            {
                Console.WriteLine($"WebDriver error: {ex.Message}");
                Assert.Fail("Test failed due to WebDriver issue.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                Assert.Fail("Test failed due to an unexpected error.");
            }
        }
    }
}
