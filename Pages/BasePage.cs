using OpenQA.Selenium;

namespace Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver), "driver can not be null");
            }

            this.driver = driver;
        }

        public void EnterUsername()
        { }

        public void EnterPassword()
        { }

        public void ClickLoginButton()
        { }
    }
}