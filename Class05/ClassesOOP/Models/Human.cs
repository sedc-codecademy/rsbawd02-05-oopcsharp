namespace ClassesOOP.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } 

        // Constructor
        public Human() { }

        public Human(string firstName, string lastName, int age) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Human(Human otherHuman)
        {
            FirstName = otherHuman.FirstName;
            LastName = otherHuman.LastName;
            Age = otherHuman.Age;
        }

        public Human(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public string GetPersonStats()
        {
            return FirstName + " " + LastName + " " + Age;
        }
    }
}
