namespace dev_9
{
    public class LocatorsMailru
    {
        public class LoginPageLocators
        {
            public string LoginLocator { get; } = "//input[@id = 'mailbox:login']";
            public string PasswordLocator { get; } = "//input[@id = 'mailbox:password']";
            public string SubmitButtonLocator { get; } = "//input[@class = 'o-control']";
        }
    }
}
