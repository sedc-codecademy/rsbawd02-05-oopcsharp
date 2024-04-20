using CommonModels.Enums;
using CommonModels.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.Id = 1;
            student1.FirstName = "TestF";
            student1.LastName = "TestL";
            student1.HomeTown = "City1";
            student1.BirthDay = new DateTime(2000, 1, 1);
            student1.Gender = Gender.Male;

            student1.UniqueStudentID = "IB14099";
            student1.AverageGrade = 9.5;
            student1.AttendingCourses = new string[] { "Math", "Programming 1" };

            Professor professor = new Professor();
            professor.Id = 2;
            professor.FirstName = "Prof1";
            professor.LastName = "ProfL";
            professor.BirthDay = new DateTime(1950, 1, 1);
            professor.HomeTown = "City2";
            professor.Gender = Gender.Female;

            professor.Biography = "Lorem ipsum...";
            professor.Materials = new string[] { "Math1 Book", "Math2 Book" };
            professor.LecturingCourses = new string[] { "Math", "Programming 1" };
            professor.Status = ProfessorStatus.Active;

            student1.PrintInfo();
            professor.PrintInfo();

            if (student1.Gender == Gender.Male)
                Console.WriteLine("Student1 je musko");
            else if (student1.Gender == Gender.Female)
                Console.WriteLine("Student1 je zensko");
            else
                Console.WriteLine("Student1 nije upisao informacije za spol");

            student1.NewInformationField = "NEW INFO";
        }
    }
}