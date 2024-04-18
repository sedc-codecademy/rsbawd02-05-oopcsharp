namespace Task2
{
    public class Program
    {
        static void Main()
        {
            bool next = true;

            do
            {
                Console.Write("Enter a number:");

                double number = Convert.ToDouble(Console.ReadLine());

                NumberStats(number);

                Console.Write("Press any key to try again or X to exit.");

                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "X")
                    next = false;

            } while (next);
        }

        public static void NumberStats(double number)
        {
            bool isNegative;
            bool isDecimal;
            bool isEven;

            if (number < 0)
                isNegative = true;
            else
                isNegative = false;

            if (number % 1 > 0)
                isDecimal = true;
            else
                isDecimal = false;

            if (number % 2 == 0)
                isEven = true;
            else
                isEven = false;

            Console.WriteLine($"Stats for number: {number}");

            Console.WriteLine(string.Format("{0}", isNegative ? "Negative" : "Positive"));
            Console.WriteLine(string.Format("{0}", isDecimal ? "Decimal" : "Integer"));
            Console.WriteLine(string.Format("{0}", isEven ? "Even" : "Odd"));
        }
    }
}
