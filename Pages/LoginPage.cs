using OpenQA.Selenium;

namespace Pages
{
    /// <summary>
    /// Represents the login page and contains login-related actions. 
    /// </summary> 
    public class LoginPage : BasePage
    {
        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
            : base(driver)
        { }

        /// <summary>
        ///  Enters the username into the username input.
        /// </summary>
        public void EnterUsername(string username)
        {
            driver.FindElement(usernameInput).SendKeys(username);
        }

        /// <summary>
        /// Enters the password into the password input.
        /// </summary>
        public void EnterPassword(string password)
        {
            driver.FindElement(passwordInput).SendKeys(password);
        }

        /// <summary>
        /// Click the login button.
        /// </summary> <>
        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        /// <summary>
        ///  Retrives the errors message inside the page.
        /// </summary>
        public string GetErrorMessage()
        {
            By errorLocator = By.XPath("//div[contains(@class, 'error')]");
            WaitForElementToBeVisible(errorLocator);
            return FindElement(errorLocator).Text;
        }

        /// <summary>
        /// Retrives the page title.
        /// </summary>
        public string GetPageTitle()
        {
            return driver.Title;
        }
    }
}
