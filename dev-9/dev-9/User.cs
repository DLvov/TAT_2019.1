namespace dev_9
{
    abstract class User
    {
        public string Mail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract void Login(string username, string password);
        public abstract void SendLetter(string destination, string message);
        public abstract bool CheckLetter(string sender, string message);
        public abstract void ChangeUsername(string newUsername);
    }
}
