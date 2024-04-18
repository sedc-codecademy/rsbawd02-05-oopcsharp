using ClassesOOPx.Models;

namespace ClassesOOPx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int     number1  = 0;
            
            Student student1 = new Student("00001");
          
            Student student23 = new Student();
            student23.fName = "Dordje";

            student1.fName = "Student1";
            student1.lName = "Prezime1";
            student1.age = 25;
            student1.jmbg = "1121212121";
            student1.courses = new string[] { "Predmet 1", "Predmet2", "Predmet3" };
            student1.homeTown = "Grad1";

            student1.birthDay = DateTime.Now;
            
            Student student2 = new Student();
            student2.fName = "Drugi student";
            student2.lName = "prezime 2";
            student2.birthDay = DateTime.Now;


            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();
            Student student6 = new Student();
            Student student7 = new Student();
            Student student8 = new Student();
            Student student9 = new Student();

            student7.birthDay = DateTime.Now;

            Student milica = new Student();

            milica.fName = "Milica";
            milica.diploma = new Diploma();

            milica.diploma.Name = "Univerzitet Banja Luka";
            milica.diploma.AwardData = new DateTime(2020, 10, 10);
            milica.diploma.Rating = 10;

            PrintStudentData(milica);
            PrintStudentData(student1);
        }

        static void PrintStudentData(Student student)
        {
            Console.WriteLine("Student Data:");

            Console.WriteLine(student.fName);

            if (student.diploma != null)
            {
                Console.WriteLine("Diploma data");
                Console.WriteLine(student.diploma.Name);
                Console.WriteLine(student.diploma.AwardData.ToShortDateString());
                Console.WriteLine("Ocjena: " + student.diploma.Rating);
            }
        }
    }
}
