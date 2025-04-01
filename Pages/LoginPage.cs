using OpenQA.Selenium;

namespace Pages
{
    public class LoginPage : BasePage
    {
        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver) : base(driver) {}

        public void EnterUsername(string username)
        {
            EnterText(usernameInput, username); // Uses BasePage method
        }

        public void EnterPassword(string password)
        {
            EnterText(passwordInput, password); // Uses BasePage method
        }

        public void ClickLoginButton()
        {
            Click(loginButton); // Uses BasePage method
        }

        public string GetErrorMessage()
        {
            By errorLocator = By.XPath("//div[contains(@class, 'error')]");
            WaitForElementToBeVisible(errorLocator); // Uses BasePage method
            return FindElement(errorLocator).Text;
        }
    }
}
