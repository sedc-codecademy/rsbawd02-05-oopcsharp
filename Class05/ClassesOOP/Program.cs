using ClassesOOP.Models;

namespace ClassesOOP
{
    internal class Proram
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            Human human1 = new Human();

            Console.Write("Human first name is: ");
            human1.FirstName = Console.ReadLine();

            Console.Write("Human last name is: ");
            human1.LastName = Console.ReadLine();

            Console.Write("Age: ");
            human1.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your input was: ");
            Console.WriteLine(human1.GetPersonStats());

            string fName = "Goran";
            string lName = "Radenkovic";
            int age = 25;

            Human human2 = new Human(fName, lName, age);
            Console.WriteLine(human2.GetPersonStats());

            Human human3 = new Human(human2);
            Console.WriteLine(human3.GetPersonStats());

            Human human4 = new Human("Tamara", "Zdravkovic");

            #endregion

            #region Exercise 2

            Dog aDog = new Dog();

            Console.WriteLine("Enter the dog's name");
            aDog.Name = Console.ReadLine();

            Console.WriteLine("Enter the dog's race");
            aDog.Race = Console.ReadLine();

            Console.WriteLine("Enter the dog's color");
            aDog.Color = Console.ReadLine();

            Console.WriteLine("What do you want the dog to do: \n 1. Feed the dog \n 2. Play \n 3. Let it chase it's tail");
            int result = Int32.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine(aDog.Eat());
                    break;
                case 2:
                    Console.WriteLine(aDog.Play());
                    break;
                case 3:
                    Console.WriteLine(aDog.ChaseTail());
                    break;
                default:
                    Console.WriteLine("No option like that. Sorry.");
                    break;
            }

            #endregion

            #region Exercise 3

            Student[] arrStudents = new Student[] {
                new Student("Bob", "G1", "Web Developemt"),
                new Student("Jill", "G2", "Design"),
                new Student("Greg", "G1", "Networks"),
                new Student("Anne", "G3", "Web Developemt"),
                new Student("Will", "G3", "Design")
            };

            Console.WriteLine("Enter a student name");
            string studentName = Console.ReadLine();
            FindStudent(arrStudents, studentName);
            #endregion

            // Profesor 1
            Teacher scottHanselman = new Teacher();
            
            Teacher zoranMalinovic = new Teacher();

            scottHanselman.Age = 29;
            scottHanselman.FirstName = "Admin";
            scottHanselman.LastName = "User nimda";
            scottHanselman.Email = "professor@gmail.com";
            scottHanselman.LearningModules = new string[] { "C# Basics", "Advanced C#"};

            scottHanselman.Email = "admin@gmail.com";
            zoranMalinovic.Email = "zoka@gmail.com";
            zoranMalinovic.FirstName = "Zoran";
            zoranMalinovic.LastName = "Malinovic";
            
            zoranMalinovic.Age = 45;
            scottHanselman.SetYearOfAward("2023");

            //zoranMalinovic.YearOfAward = "2004";
            zoranMalinovic.SetYearOfAward("2004");

            Console.WriteLine(scottHanselman.Email);
            //Console.WriteLine(zoranMalinovic.Email);

            zoranMalinovic.SayHello();

            // Profesor 2
            Teacher professor2 = new Teacher();

            professor2.Age = 40;
            professor2.FirstName = "Teacher";
            professor2.LastName = "TWO";
            professor2.Email = "professor222222@gmail.com";
            professor2.LearningModules = new string[] { "Database Development" };

            Teacher mirosalv = new Teacher();
            mirosalv.Age = 45;

            Teacher almir = new Teacher();
            almir.FirstName = "Almy";

            Teacher professor5 = new Teacher();
            Teacher professor6 = new Teacher();
            Teacher professor7 = new Teacher();
            Teacher professor8 = new Teacher();

        }
        public static void FindStudent(Student[] students, string name)
        {
            bool studentFound = false;
            while (studentFound == false)
            {
                foreach (var student in students)
                {
                    if (name.ToLower() == student.Name.ToLower())
                    {
                        Console.WriteLine($"Student found: \n Name: {student.Name} \n Group: {student.Group} \n Academy: {student.Academy}");
                        studentFound = true;
                    }
                }
                if (studentFound == false)
                {
                    Console.WriteLine("There is no such student, please try again");
                    name = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
