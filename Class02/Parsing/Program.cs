namespace Parsing
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Write your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Your name is: {userName}");

            Console.Write("How old are you: ");
            string userInputString = Console.ReadLine();

            int userAge = int.Parse(userInputString);

            int userAge2 = Convert.ToInt32(userAge);

            Console.WriteLine($"You are {userAge} years old");
            Console.WriteLine($"You are {userAge2} years old");

            Console.WriteLine("What is the value of pi?");
            double piValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your answer is {piValue}");
        }
    }
}
