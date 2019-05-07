namespace dev_9
{
    class UserMailru : User
    {
        public UserMailru(string username, string password)
        {
            this.Mail = "https://mail.ru/";
            this.Username = username;
            this.Password = password;
        }

        public override void Login(string username, string password) { }
        public override void SendLetter(string destination, string message) { }
        public override bool CheckLetter(string sender, string message) { return true; }
        public override void ChangeUsername(string newUsername) { }
    }
}
