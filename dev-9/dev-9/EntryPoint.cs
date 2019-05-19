using System;

namespace dev_9
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var protonUser = new User("vasyapupkin4484", "passslovo56223");
            var mailruUser = new User("vasya.pupkin1988148", "passslovo63728");
            var loginPage = new LoginPageMailru();
            loginPage.LoginAndNavigateToInboxPage(mailruUser);
        }
    }
}