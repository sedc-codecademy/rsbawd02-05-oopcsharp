using Task33.Models;

namespace Task33
{
    internal class Program
    {
        static User[] Users = new User[20];

        static int lastUserIndex = 0;

        static void Main(string[] args)
        {
            User user1 = new User(1, "prviUser", "jedan");
            User user2 = new User(2, "drugiUser", "dva");
            User user3 = new User(3, "treciUser", "tri");

            user1.Messages[0] = "New email arrived";
            user1.Messages[1] = "New SMS arrived";

            user2.Messages[0] = "New SMS just arrived";
            user3.Messages[0] = "New Notification arrived";

            Users[0] = user1;
            Users[1] = user2;
            Users[2] = user3;

            lastUserIndex = 3;

            bool next = true;
 
            do
            {
                Console.WriteLine("Odaberi jednu od ponudjenih opcija: ");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");

                Console.Write("Vas odabir je? ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Login();
                        break;

                    case 2:
                        Register();
                        break;

                    default:
                        Console.WriteLine("Non valid operation selected");
                        break;
                }

                Console.WriteLine("Do you want to continue? Y/N");

                string userOption = Console.ReadLine();

                if (userOption.ToUpper() == "N")
                    next = false;

            } while (next);
        }

        static void Login()
        {
            Console.Write("Username: ");
            string userInputUsername = Console.ReadLine();

            Console.Write("Password: ");
            string userInputPassword = Console.ReadLine();

            User foundUser = null;

            foreach (User user in Users)
            {
                if (user == null)
                    continue;

                if (user.UserName == userInputUsername &&
                    user.Password == userInputPassword)
                {
                    foundUser = user;
                }
            }

            if (foundUser == null)
            {
                Console.WriteLine("There is no user with that username and password");
                return;
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Welcome {foundUser.UserName}, here are your messages:");

            foreach (string message in foundUser.Messages)
                Console.WriteLine($" - {message}");
            Console.WriteLine("---------------------------------------------------------");
        }

        static void Register()
        {
            Console.Write("ID: ");
            int userInputID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Username: ");
            string userInputUsername = Console.ReadLine();

            Console.Write("Password: ");
            string userInputPassword = Console.ReadLine();

            foreach (User user in Users)
            {
                if (user == null)
                    continue;

                if (user.UserName == userInputUsername)
                {
                    Console.WriteLine("There is already an user with that username");
                    return;
                }
            }

            User newUser = new User(userInputID, userInputUsername, userInputPassword);

            Users[lastUserIndex] = newUser;
            lastUserIndex++;

            Console.WriteLine("Registration complete!");

            Console.WriteLine("All users are: ");

            foreach (User user in Users)
            {
                if (user == null)
                    continue;

                Console.WriteLine($" - {user.UserName}");
            }
        }
    }
}
