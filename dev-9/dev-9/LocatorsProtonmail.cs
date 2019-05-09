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

        public class InboxPageLocators
        {
            public string NewLetterButtonLocator { get; } = "//button[@class contains() = 'sidebar-btn-compose']";
            public string LastInboxLetterLocator { get; } = "//div[@class = 'conversation-meta']";
            public string MessageContentLocator { get; } = "//div[@class = 'bodyDecrypted email message-body-container']";
            public string SettingsButtonLocator { get; } = "//a[@id = 'tour-settings']";
        }

        public class NewLetterPageLocator
        {
            public string RecipientLocator { get; } = "//input[@class = 'autocompleteEmails-input no-outline']";
            public string SubjectLocator { get; } = "//input[@ng-model = 'message.Subject']";
            public string TextLocator { get; } = "//html[@class = 'c']/body";
            public string SendMessageButtonLocator { get; } = "//button[@class = 'pm_button primary mobileFull composer-btn-send btnSendMessage-btn-action']";
        }

        public class SettingsPageLocator
        {
            public string NickNameLocator { get; } = "//input[@id = 'displayName']";
            public string SaveButtonlocator { get; } = "//button[@class = 'pm_button primary']";
        }
    }
}
