namespace CommonModels.Models
{
    public class Student : Person
    {
        public Student() { }

        public Student(int id, string fName, string lName, DateTime birthDay, string hometown, 
            string uniqueStudentId, string[] attendingCourses, double averageGrade) 
            : base(id, fName, lName, birthDay, hometown)
        {
            UniqueStudentID = uniqueStudentId;
            AttendingCourses = attendingCourses;
            AverageGrade = averageGrade;
        }

        public string UniqueStudentID { get; set; }
        public string[] AttendingCourses { get; set; }
        public double AverageGrade { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Student Info: ");

            base.PrintInfo();

            Console.WriteLine($"{UniqueStudentID} - {AverageGrade}");

            Console.WriteLine("Student, Attending Courses:");

            foreach (string course in AttendingCourses)
                Console.WriteLine(course);
        }
    }
}
