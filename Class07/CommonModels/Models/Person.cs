using CommonModels.Enums;

namespace CommonModels.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string HomeTown { get; set; }

        public Gender Gender { get; set; }

        public string NewInformationField { get; set; }

        public Person() { }

        public Person(int id, string fName, string lName, DateTime birthDay, string hometown)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            BirthDay = birthDay;
            HomeTown = hometown;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Id} - {FirstName} {LastName} - {BirthDay.ToShortDateString()} - {HomeTown}");
        }
    }
}
