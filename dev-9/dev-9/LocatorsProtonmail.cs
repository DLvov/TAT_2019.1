namespace dev_9
{
    class LocatorsProtonmail
    {
        public class LoginPageLocators
        {
            public string LoginLocator { get; } = "//input[@id = 'username']";
            public string PasswordLocator { get; } = "//input[@id = 'password']";
            public string SubmitButtonLocator { get; } = "//input[@id = 'login_btn']";
        }
    }
}
