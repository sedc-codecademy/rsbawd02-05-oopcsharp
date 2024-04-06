namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fixed size array
            int[] numbersArray = new int[10];

            numbersArray[0] = 1;
            numbersArray[1] = 2;
            numbersArray[2] = 3;
            numbersArray[3] = 412;
            numbersArray[4] = 512;            
            numbersArray[5] = 15;
            numbersArray[6] = 53;
            numbersArray[7] = 125;
            numbersArray[8] = 533;
            numbersArray[9] = 125;

            // numbersArray[5] = 6; This will not work, there is no element at 5th position

            // Print out the values
            Console.WriteLine("The array elements are:");
            
            for (int i = 0; i < numbersArray.Length; i++)
                Console.WriteLine(numbersArray[i]);

            // Non fixed array
            string[] studentsArray = new string[]
            {
                "Milica", "Tamara", "Goran", "Stefan", "Sava"
            };

            int[] studentsRatingsArray = new int[] { 10, 10, 10, 10, 10 };

            Console.WriteLine("Students: ");
            
            // Foreach loop
            foreach (string student in studentsArray)
                Console.WriteLine(student);

            Console.WriteLine("Students ratings:");
            foreach (int rating in studentsRatingsArray)
                Console.WriteLine(rating);

            #region Exercises
            // Exercise 1
            string[] words = new string[] { "Hello", "Hi", "Wow", "Words", "Dinosaur" };
            double[] decimals = new double[] { 2.4, 5.4444, 0.00009, 18.9, 999.0002 };
            char[] characters = new char[] { 'b', 'c', '0', '#', ']' };
            bool[] booleans = new bool[] { true, false, false, true, false };
            
            // 2D array example
            int[][] arraysOfInts = new int[][] {
                new int[] {2, 4},
                new int[] {-6, 12},
                new int[] {0, 99},
                new int[] {32, 27},
                new int[] {9999, 50}
            };

            // Exercise 2 
            int[] arrayOfIntegers1 = new int[5];
            int sum1 = 0;

            for (int i = 0; i < arrayOfIntegers1.Length; i++)
            {
                Console.WriteLine("Enter index " + i);
                int number = int.Parse(Console.ReadLine());
                arrayOfIntegers1[i] = number;
            }
            
            foreach (int num in arrayOfIntegers1) 
                sum1 += num;
            
            Console.WriteLine("The result is: " + sum1);

            // Exercise 2 (Solution 2)
            int[] arrayOfIntegers2 = new int[5];
            int sum2 = 0;
            int j = 0;

            while (j < arrayOfIntegers2.Length)
            {
                Console.WriteLine("Enter index " + j);

                sum2 += arrayOfIntegers2[j];
                j++;
                
                if (j == arrayOfIntegers2.Length) 
                    Console.WriteLine("The result is: " + sum2);
            }

            // Exercise 3 
            string[] fullNames = new string[20];

            int counter = 0;
            while (true)
            {
                Console.WriteLine("Please enter a name from the keyboard:");
                string name = Console.ReadLine();

                fullNames[counter] = name;
               
                Console.WriteLine("Do you want to enter another name?");

                if (Console.ReadLine() == "N") 
                    break;
            }

            Console.WriteLine("Names stored:");

            foreach (string currentName in fullNames)
                Console.WriteLine(currentName);

            #endregion

        }
    }
}
