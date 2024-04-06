namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FOR - loop example

            Console.WriteLine("FOR Loop: --------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i: {i}");
            }

            // Infinite for loop
            for(; ; )
            {
                Console.WriteLine("This will go on forver unless you enter X");
                string userInput = Console.ReadLine();

                if (userInput == "X" || userInput == "x")
                    break;
            }

            // forr - reverse for loop
            for (int i = 10; i > 0; i--)
                Console.WriteLine($"The value of i: {i}");

            Console.WriteLine("... Happy new year!");
            Console.WriteLine("We are outside of the loop...");

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("While loop: ------------------------------");

            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"The value is: {counter}");
                counter++;
            }

            // Infinite while loop
            string userInputX = string.Empty;

            // Homework - do not execute next iteration if user inputs x or X
            while (userInputX != "X" && userInputX != "x")
            {
                Console.WriteLine("This will go on forver unless you enter X");
                userInputX = Console.ReadLine();
            }

            Console.WriteLine("We are outside of the loop...");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Do-While loop: ------------------------------");

            int doWhileCounter = 0;

            do
            {
                Console.WriteLine($"The value of counter is {doWhileCounter}");
                doWhileCounter++;

            } while (doWhileCounter < 10);

            int anotherCounter = 100;
            
            do
            {
                Console.WriteLine($"Another counter value is {anotherCounter}");
                anotherCounter++;

            } while (anotherCounter < 10);

            Console.WriteLine("We are outside of the loop...");
            Console.WriteLine("------------------------------------------");

            // Exercise :D

            /*
             * Exercise 1:
               
               Get an input number from the console​
               Print all numbers from 1 to that number​
            
               Get another input number from the console​
               Print all numbers from that number to 1​
            */

            int numA = 0;

            Console.WriteLine("Please input number: ");
            numA = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= numA; i++)
                Console.Write(i + ", ");

            Console.WriteLine();

            int numB = 0;

            Console.WriteLine("Please input number: ");
            numB = Convert.ToInt16(Console.ReadLine());

            for (int i = numB; i >= 1; i--)
                Console.Write(i + ", ");

            /*
             * Exercise 2:
             
               Get an input number from the console​
               Print all even numbers starting from 2​
             
               Get another input number from the console​
               Print all odd numbers starting from 1​
             
             */

            int numC = 0;

            Console.WriteLine("Please input number: ");
            numC = Convert.ToInt16(Console.ReadLine());

            // #1 solution
            for (int i = 2; i <= numC; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + ", ");
            }

            // #2 solution
            for (int i = 2; i <= numC; i += 2)
                Console.Write(i + ", ");

            Console.WriteLine();

            int numD = 0;

            Console.WriteLine("Please input number: ");
            numD = Convert.ToInt16(Console.ReadLine());

            // #1 solution
            for (int i = 1; i <= numD; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + ", ");
            }

            /*
             * Exercise 3:
               Get an input from the console​
               Print all numbers from 1 to that number​
               
               Don’t print numbers that can be divided by 3 or 7​
               If the number gets to 100 print a message: The limit is reached and stop counting​
             */

            int numE = 0;

            Console.WriteLine("Please input number: ");
            numE = Convert.ToInt16(Console.ReadLine());

            // #1 solution
            for (int i = 1; i <= numE; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                    continue;

                Console.Write(i + ", ");

                if (i == 100)
                {
                    Console.WriteLine("The limit is reached​");
                    break;
                }
            }
        }
    }
}