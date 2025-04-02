using Pages;
using Xunit;

namespace Tests
{
    /// <summary>
    /// Contains login test cases for validation.
    /// </summary>
    public class LoginTests : BaseTest
    {
        private readonly LoginPage loginPage;

        public LoginTests()
        {
            loginPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Fact]
        public void InvalidLogin_WithEmptyCredentials()
        {
            // Arrange
            string expectedErrorMessage = "Username is required";

            // Act
            loginPage.EnterUsername(string.Empty);
            loginPage.EnterPassword(string.Empty);
            loginPage.ClickLoginButton();
            string actualErrorMessage = loginPage.GetErrorMessage();

            // Assert
            Assert.Contains(expectedErrorMessage, actualErrorMessage);
        }

        [Fact]
        public void InvalidLogin_WithEmptyPassword()
        {
            // Arrange
            string expectedErrorMessage = "Password is required";

            // Act
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword(string.Empty);
            loginPage.ClickLoginButton();
            string actualErrorMessage = loginPage.GetErrorMessage();

            // Assert
            Assert.Contains(expectedErrorMessage, actualErrorMessage);
        }

        [Fact]
        public void ValidLogin_WithValidCredentials()
        {
            // Arrange
            string expectedTitle = "Swag Labs";

            // Act
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
            loginPage.ClickLoginButton();
            string actualTitle = loginPage.GetPageTitle();

            // Assert
            Assert.Contains(expectedTitle, actualTitle);
        }
    }
}
