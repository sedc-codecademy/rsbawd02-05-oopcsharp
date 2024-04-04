namespace CSharpDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Types

            int integerVariable1 = 5;
            int integerVariable2 = 0;

            int variable3 = 3100020;

            Console.WriteLine("Vrijednost varijable 1 je: " + integerVariable1);
            Console.WriteLine("Vrijednost varijable 2 je: " + integerVariable2);

            integerVariable1 = 500;
            integerVariable1 = 1000;

            Console.WriteLine("Vrijednost varijable 1 je: " + integerVariable1);

            integerVariable1 = -500;

            // uint postiveNumbersOnly = 300;

            float floatVariable = 2.5F;
            double doubleVariable = 2.5;

            Console.WriteLine($"Vrijednost floatVariable je: {floatVariable}");
            Console.WriteLine("Vrijednost doubleVariable je: " + doubleVariable);

            string message = "Hello students";
            char singleCharacterValue = 'a';

            Console.WriteLine(message);

            bool isPrinted = false;
            bool isEnabled = true;

            Console.WriteLine($"Document is enabled: {isEnabled}");
            Console.WriteLine($"Document is printed: {isPrinted}");

            string firstName = "Almir";
            string first_name = "almir";

            // Bad example
            string firstname = "Almir";

            string CONFIGURATION_KEY_ID = "1212121213221312312";

            Console.WriteLine(firstName);
            Console.WriteLine(CONFIGURATION_KEY_ID);

            int firstNumber = 10;
            int secondNumber = 20;

            int sum = firstNumber + secondNumber;
            int multipilcationResult = firstNumber * secondNumber;

            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Result of multipilcation is {multipilcationResult}");

            firstNumber++;
            firstNumber--;

            ++firstNumber;

            firstNumber += 10; // firstNumber = firstNumber + 10;

            /*
           * # 1
           Declare two double variables​
           Initialize them and divide them in a new variable​
           Declare two integer variables​
           Initialize them and divide them in a new variable​
           Print the results in the console and compare​
           */

            // double a1, b1;
            double a1 = 10;
            double b1 = 3;

            double divDoubleValues = a1 / b1;

            int i1 = 10;
            int i2 = 3;

            int resultX = i1 / i2;

            Console.WriteLine("Double division result: " + divDoubleValues);
            Console.WriteLine("Int division result: " + resultX);

            Console.WriteLine("----------------------------------------");

            /*
             * #2
            Declare two string variables​ 
            Initialize them and concatenate them in a new variable​ 
            Declare two string variables​ 
            Initialize them with the number 9 and 3​ 
            Concatenate them in a new variable​ 
            Print the results in the console​
            */

            string firstName1 = "Ime";
            string lastName1 = "Prezime";

            string fullName1 = firstName1 + lastName1;

            Console.WriteLine(fullName1);

            string s1 = "9";
            string s2 = "3";

            string s3 = s1 + s2;

            Console.WriteLine("The result of these numbers is: " + s3);

            Console.WriteLine("----------------------------------------");

            /*
             * #3
             Declare an integer and a string variable​
             Initialize them and concatenate them in a new variable​
             Print the result in the console​
             */

            int number = 9;
            string stringValue;

            stringValue = "Code";

            string resutS = stringValue + number;

            Console.WriteLine(resutS);

            number = 101;

            string resutS2 = stringValue + number;
            Console.WriteLine(resutS2);

            Console.WriteLine("----------------------------------------");

            /*
            * # 4
            You have n credits on your mobile bill. One SMS costs m credits. 
            How many SMS messages you can send?​
            n = 102​
            m = 5​
            Result = ?​
             */

            int credits = 102;
            int messageCost = 5;

            int messagesCount = credits / messageCost;

            Console.WriteLine("Dostupan broj SMS-ova za slanje je: " + messagesCount);
        }
    }
}
