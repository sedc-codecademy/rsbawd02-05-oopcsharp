namespace LINQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>()
            {
                "Tamara", "Sava", "Goran", "Milica", "John", "Manuel", "Stefan", "Almir"
            };

            foreach (string studentName in students)
            {
                if (studentName.Length == 4)
                    Console.WriteLine($"Ovaj student ima 4 slova u svom imenu {studentName}");
            }

            // Manual approach
            List<string> studentsWith5Letters = new List<string>();

            foreach (string studentName in students)
            {
                if (studentName.Length == 5)
                    studentsWith5Letters.Add(studentName);
            }

            // LINQ approach
            List<string> studentsWithFiveLetters = students
                .Where(item => item.Length == 5)
                .ToList();

            Console.WriteLine("Pet slova u svom imenu");
            foreach (string studentName in studentsWithFiveLetters)
                Console.WriteLine(studentName);

            // Manual
            List<int> nameLengths = new List<int>();

            foreach (string studentName in students)
            {
                nameLengths.Add(studentName.Length);
            }

            // LINQ approach
            List<int> studentNameLengths = students
                .Select(item => item.Length)
                .ToList();

            // First item
            Console.WriteLine(students.First());
            Console.WriteLine(students.FirstOrDefault());

            // Last item
            Console.WriteLine(students.Last());
            Console.WriteLine(students.LastOrDefault());
        }
    }
}
