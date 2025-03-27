using OpenQA.Selenium;

namespace Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver), "driver can not be null.");
            }

            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameInput).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordInput).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }
    }
}
