namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type any positive or negative number: ");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());

            if (userInputNumber > 0) 
                Console.WriteLine("The number is postive");
            else if (userInputNumber < 0)
                Console.WriteLine("The number is negative");
            else
                Console.WriteLine("The number is zero");

            Console.WriteLine("Switch : -------------------------------------------------");

            Console.WriteLine("1. Monday\n2. Tuesday\n3. Wednesday\n4. Thursday\n5. Friday\n6. Saturday\n7. Sunday");
            int userInputDay = Convert.ToInt32(Console.ReadLine());

            switch (userInputDay)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Work day :(");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Happy");
                    break;

                default:
                    Console.WriteLine("Outside of valid values!");
                    break;
            }
        }
    }
}