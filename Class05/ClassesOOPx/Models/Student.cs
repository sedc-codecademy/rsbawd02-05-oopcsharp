namespace ClassesOOPx.Models
{
    public class Student
    {
        public Student()
        {
            
        }

        public Student(string studentUniqueValue)
        {
            string jmbgData = "Neka vrijednost sa web servisa drzave ovog studenta";
            jmbg = jmbgData;
        }

        public Student(string fName, string lName, int age, string jmbg, 
            string[] courses, string homeTown, DateTime birthDay, Diploma diploma)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            this.jmbg = jmbg;
            this.courses = courses;
            this.homeTown = homeTown;
            this.birthDay = birthDay;
            this.diploma = diploma;
        }

        public string fName;
        public string lName;
        public int age;
        public string jmbg;
        public string[] courses;
        public string homeTown;

        public DateTime birthDay;

        public Diploma diploma;

    }
}
