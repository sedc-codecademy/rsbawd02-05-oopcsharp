namespace WorkWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String building
            string name = "Almir";
            string mostar = "Mostar";
            string academy = "Qinshift Academy";

            string hello1 = "Hello " + name;
            string hello2 = string.Format("Hello {0} and I am from {1} and I am {2} teacher", name, mostar, academy);
            string hello3 = $"Hello {name} and I am from {mostar} and I am {academy} teacher";

            Console.WriteLine(hello1);
            Console.WriteLine(hello2);
            Console.WriteLine(hello3);

            Console.WriteLine("----------------------------");

            // String formatting

            string currency = string.Format("{0:C}", 125.45);
            string percent = string.Format("{0:P}", 0.87);
            string customFormat = string.Format("{0:0##-###-###}", 060111343);

            string customAlignment = string.Format("| {0,10} | {1,10} |", "Id", "Order");
            string customAlignment2 = string.Format("| {0,10} | {1,10} |", "1", "Narudzba1");

            Console.WriteLine("Currency formatting: " + currency);
            Console.WriteLine("Percentage formatting: " + percent);
            Console.WriteLine("Telephone number formatting: " + customFormat);
            Console.WriteLine(customAlignment);
            Console.WriteLine(customAlignment2);

            Console.WriteLine("----------------------------");

            // Escaping strings
            string a = "Your file is located at: C:\\Users\\Public";
            string b = "We will have \"fair\" elections";
            string c = "This is first part before new line\nThis is now in a new line";
            string e = "In C# we use \\n to go into a new line";

            string aa = @"Your file is located at: C:\Users\Public";
            string bb = @"We will have ""fair"" elections";
            string cc = @"In C# we use \n to go into a new line";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(e);

            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(cc);

            Console.WriteLine("----------------------------");

            string ourString = "     We are learning C# and it is FUN and EASY. Okay, maybe just FUN. And this is third part.     ";

            string lowerCase = ourString.ToLower();
            string upperCase = ourString.ToUpper();

            Console.WriteLine(lowerCase);
            Console.WriteLine(upperCase);

            // Length of the string
            int ourStringLength = ourString.Length;
            Console.WriteLine($"Length of our string is {ourStringLength}");

            string[] splitted = ourString.Split('.');

            foreach (string part in splitted)
                Console.WriteLine(part);

            string trimmedString = ourString.Trim();
            Console.WriteLine(trimmedString + "KRAJ");

            string part1 = "Ovo je cetvrti cas";
            string part2 = "predmeta C#";
            string part3 = "u Qinshift akademiji programiranja, i polaznici rade domacu zadacu redovno";

            string[] qinshiftAcademy = new string[] { part1, part2, part3};

            string joinedContent = string.Join(", ", qinshiftAcademy);

            Console.WriteLine(joinedContent);

            int indexOfWordFun = ourString.IndexOf("FUN");
            int indexOfWordAlmir = ourString.IndexOf("Almir");

            Console.WriteLine($"Index value of word FUN: {indexOfWordFun}");
            Console.WriteLine($"Index value of word Almir: {indexOfWordAlmir}");

            if (ourString.Contains("FUN"))
                Console.WriteLine("There is a word FUN in original string");

            string funPartOfString = ourString.Substring(indexOfWordFun, ourString.Length - indexOfWordFun);
            Console.WriteLine(funPartOfString);

            while (!SubstringsExercise())
                Console.ReadLine();
        }

        static bool SubstringsExercise()
        {
            string a = "Hello from SEDC Codecademy 2021";
            Console.WriteLine("Please enter a number");
            int result;

            string b = "";

            if (int.TryParse(Console.ReadLine(), out result) != true)
            {
                Console.WriteLine("You have entered an incorrect format,\nPress any key to try again!");
                return false;
            }

            if (result > a.Length)
            {
                Console.WriteLine("You have entered an incorrect number,\nPress any key to try again!");
                return false;
            }

            for (int i = 0; i < result; i++)
                b += a[i];
            
            Console.WriteLine(b);
            return true;
        }
    }
}
