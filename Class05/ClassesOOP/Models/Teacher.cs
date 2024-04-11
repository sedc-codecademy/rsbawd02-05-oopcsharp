namespace ClassesOOP.Models
{
    public class Teacher
    {
        public int Id;
        public string FirstName;
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email;
        public string CurrentJobTitle { get; set; }
        public string[] LearningModules { get; set; }

        private string YearOfAward;

        public void SetYearOfAward(string yearOfAward)
        {
            if (YearOfAward == "2024")
                Console.WriteLine("Trenutna godina ne moye biti dio nagrade");

            if (YearOfAward == "2023")
                Console.WriteLine("Ova godina nije podrzana");

            YearOfAward = yearOfAward;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName} " +
                $"and I am {Age} years " +
                $"old, btw I won the award on {YearOfAward}");
        }
    }
}
