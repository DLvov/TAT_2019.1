namespace dev_9
{
    public class LocatorsMailru
    {
        public class LoginPageLocators
        {
            public string URL { get; } = "https://mail.ru/";
            public string LoginLocator { get; } = "//input[@id = 'mailbox:login']";
            public string PasswordLocator { get; } = "//input[@id = 'mailbox:password']";
            public string SubmitButtonLocator { get; } = "//input[@class = 'o-control']";
        }

        public class InboxPageLocators
        {
            public string NewLetterButtonLocator { get; } = "//a[@class = 'b-toolbar__btn b-toolbar__btn_with-foldings js-shortcut']";
            public string LastInboxLetterLocator { get; } = "//div[@class = 'b-datalist__item__body']";
            public string MessageContentLocator { get; } = "//div[@class = 'class_1557437996']";
            public string ProfileLocator { get; } = "//i[@id = 'PH_user-email']";
            public string SettingsButtonLocator { get; } = "//a[@class = 'x-ph__menu__dropdown_auth__links__link']";
        }

        public class NewLetterPageLocator
        {
            public string RecipientLocator { get; } = "//textarea[@tabindex='4']";
            public string SubjectLocator { get; } = "//input[@class = 'b-input']";
            public string TextLocator { get; } = "//body[@id = 'tinymce']";
            public string SendMessageButtonLocator { get; } = "//div[@data-bem = 'b-toolbar__btn']";
        }

        public class SettingsPageLocator
        {
            public string NickNameLocator { get; } = "//input[@name = 'NickName']";
            public string SaveButtonlocator { get; } = "//button[@class = 'btn btn_main btn_stylish']";
        }
    }
}
