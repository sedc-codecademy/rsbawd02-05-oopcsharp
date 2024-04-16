namespace WorkingWithDates
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = new DateTime(2024, 4, 16, 18, 3, 0);
            DateTime currentDay = DateTime.Today;
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine(currentDate);
            Console.WriteLine(currentDay);
            Console.WriteLine(currentDateTime);

            string dateFormat1 = currentDateTime.ToString("dd.MM.yyyy");
            Console.WriteLine(dateFormat1);

            string dateFormat2 = currentDateTime.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine(dateFormat2);

            DateTime dateAfter100Days = currentDateTime.AddDays(100);
            Console.WriteLine($"Nakon 100 dana: {dateAfter100Days}");

            DateTime removed1000Days = currentDateTime.AddDays(-1000);
            Console.WriteLine($"Prije 1000 dana od danas je bio : {removed1000Days}");

            DateTime after30000Hours = currentDateTime.AddHours(30000);
            Console.WriteLine($"Nakon 30000 sati: {after30000Hours}");

            DateTime myBirthDay = new DateTime(1985, 12, 25);

            Console.WriteLine($"Ja sam se rodio: {myBirthDay}");
            Console.WriteLine($"Ja sam se rodio {myBirthDay.Year} godine");
            Console.WriteLine($"Ja sam se rodio {myBirthDay.Month} mjeseca");
            Console.WriteLine($"Ja sam se rodio: {myBirthDay.Day} dana");
            Console.WriteLine($"Ja sam se rodio, a dan u sedmici je bio {myBirthDay.DayOfWeek}");
        }
    }
}