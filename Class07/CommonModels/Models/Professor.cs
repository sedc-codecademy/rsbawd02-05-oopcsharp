using CommonModels.Enums;

namespace CommonModels.Models
{
    public class Professor : Person
    {
        public string[] LecturingCourses { get; set; }
        public string[] Materials { get; set; }
        public string Biography { get; set; }
        public ProfessorStatus Status { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Professor Info: ");

            base.PrintInfo();

            Console.WriteLine($"{Biography}");

            switch (Status)
            {
                case ProfessorStatus.None:
                    Console.WriteLine("Professor status is: None");
                    break;
                case ProfessorStatus.Active:
                    Console.WriteLine("Professor status is: Active");
                    break;
                case ProfessorStatus.Inactive:
                    Console.WriteLine("Professor status is: Inactive");
                    break;
                case ProfessorStatus.Waiting:
                    Console.WriteLine("Professor status is: Waiting");
                    break;
            }

            Console.WriteLine("Lecturing courses:");
            foreach (string course in LecturingCourses)
                Console.WriteLine(course);

            Console.WriteLine("Books:");
            foreach (string material in Materials)
                Console.WriteLine(material);
        }
    }
}
