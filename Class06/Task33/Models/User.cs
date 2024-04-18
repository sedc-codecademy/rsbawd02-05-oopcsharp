namespace Task33.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string[] Messages { get; set; }

        public User(int id, string userName, string password)
        {
            Messages = new string[10];

            Id = id;
            UserName = userName;
            Password = password;
        }
    }
}
