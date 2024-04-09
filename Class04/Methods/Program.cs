namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            // Calling the method
            SayHello();

            // Calling the method with return value
            string message = PrintMyName("Almir");

            // Console.WriteLine(PrintMyName("Almir"));
            Console.WriteLine(message);

            string fName = "Almir";
            Console.WriteLine(PrintMyInfo(fName, "Vuk"));

            Console.WriteLine("--------------------------");

            Exercise1();
        }
        
        // Definition of a simple void method
        static void SayHello()
        {
            Console.WriteLine("Hello from our first method");
        }

        // Definition of a simple method which returns a string value
        static string PrintMyName(string name)
        {
            string message = $"Hi from another method, your name is {name}";

            return message;
        }

        static string PrintMyInfo(string firstName, string lastName) 
        {
            return $"Your name is {firstName} {lastName}";
        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static void Exercise1()
        {
            Console.Write("Enter an operation ( + or - ):");
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-")
            {
                Console.WriteLine("Sorry! Wrong input!");
                return;
            }

            Console.Write("Enter first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number:");
            int number2 = int.Parse(Console.ReadLine());
            
            if (operation == "+") 
                Console.WriteLine(Sum(number1, number2));

            if (operation == "-") 
                Console.WriteLine(Subtract(number1, number2));
        }
    }
}
