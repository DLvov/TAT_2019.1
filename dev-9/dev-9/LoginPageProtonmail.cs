using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace dev_9
{
    class LoginPageProtonmail
    {
        public IWebDriver Driver { get; set; }
        public IWebElement LoginArea { get; set; }
        public IWebElement PasswordArea { get; set; }
        public IWebElement SubmitButton { get; set; }

        public LoginPageProtonmail()
        {
            Driver = new ChromeDriver("D:\\SeleniumDriver");
            var locators = new LocatorsProtonmail.LoginPageLocators();
            Driver.Navigate().GoToUrl(locators.URL);
            LoginArea = Driver.WaitAndFindElementBy(By.XPath(locators.LoginLocator));
            PasswordArea = Driver.WaitAndFindElementBy(By.XPath(locators.PasswordLocator));
            SubmitButton = Driver.WaitAndFindElementBy(By.XPath(locators.SubmitButtonLocator));
        }

        public void LoginAndNavigateToInboxPage(User user)
        {
            LoginArea.SendKeys(user.Username);
            PasswordArea.SendKeys(user.Password);
            SubmitButton.Click();
        }
    }
}
