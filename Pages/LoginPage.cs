using OpenQA.Selenium;

namespace Pages
{
    public class LoginPage : BasePage
    {
        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
            : base(driver)
        { }

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

        public string GetErrorMessage()
        {
            By errorLocator = By.XPath("//div[contains(@class, 'error')]");
            WaitForElementToBeVisible(errorLocator);
            return FindElement(errorLocator).Text;
        }
        public string GetPageTitle()
        {
            return driver.Title;
        }
    }
}
