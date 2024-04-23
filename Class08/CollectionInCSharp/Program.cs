using CollectionInCSharp.Models;
using System.Net.Http.Headers;

namespace CollectionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------- List --------------------");

            List<string> studentNames = new List<string>();

            // Add element to the list
            studentNames.Add("John");
            studentNames.Add("Djordje");
            studentNames.Add("Tamara");
            studentNames.Add("Sava");
            studentNames.Add("Goran");
            studentNames.Add("Milica");

            // Remove element from List
            studentNames.Remove("John");

            Console.WriteLine("Student names: ");
            foreach (string namex in studentNames)
                Console.WriteLine(namex);

            string search = "Tamara";

            if (studentNames.Contains(search))
                Console.WriteLine($"There is a student with name: {search}");

            Console.WriteLine($"There is {studentNames.Count} elements in this List");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 100, 200, 300 };

            Console.WriteLine("Numbers are: ");
            foreach (int number in numbers)
                Console.WriteLine(number);

            Console.WriteLine($"On position 3 there is a number: {numbers[2]}");
            Console.WriteLine($"On position 5 there is a number: {numbers.ElementAt(4)}");

            numbers.RemoveAt(1);
            Console.WriteLine($"On position 2 there is a number: {numbers[1]}");

            numbers.Add(1000);

            Console.WriteLine("------------------------- Dictionary --------------------");

            Dictionary<string, int> studentGrades = new Dictionary<string, int>();

            studentGrades.Add("Djordje", 10);
            studentGrades.Add("Tamara", 10);
            studentGrades.Add("John", 7);
            studentGrades.Add("Sava", 10);
            studentGrades.Add("Bob", 8);
            studentGrades.Add("Gorana", 10);
            studentGrades.Add("Sam", 7);
            studentGrades.Add("Milica", 10);
            // studentGrades.Add("Milica", 9); -> we can not add another pair with same key 

            Console.WriteLine("Students and grades:");
            foreach (KeyValuePair<string, int> grade in studentGrades)
                Console.WriteLine($"Student: {grade.Key} - ocjena: {grade.Value}");

            // Search with Contains methods
            if (studentGrades.ContainsKey("Milica"))
                Console.WriteLine("There is a student called Milica");

            if (studentGrades.ContainsValue(7))
                Console.WriteLine("There is a student with grade 7 in the database");

            Console.WriteLine($"There is {studentGrades.Count} key-value pairs in this Dictionary");

            Console.WriteLine($"Student Gorana has grade: {studentGrades["Gorana"]}");
            Console.WriteLine($"Student John has grade: {studentGrades["John"]}");

            Dictionary<string, bool> todoList = new Dictionary<string, bool>()
            {
                { "Wash a car", false},
                { "Get groceries", true},
                { "Write homework", true}
            };

            Console.WriteLine("------------------------- Queue --------------------");

            Queue<string> queueInShop = new Queue<string>();

            queueInShop.Enqueue("Goran  (prvi dosao)");
            queueInShop.Enqueue("Milica (druga dosla)");
            queueInShop.Enqueue("Almir  (treci dosao)");

            foreach (string element in queueInShop)
                Console.WriteLine(element);

            queueInShop.Dequeue();
            Console.WriteLine($"Klijent je platio... idemo dalje {queueInShop.Peek()} je na redu");

            foreach (string element in queueInShop)
                Console.WriteLine(element);

            queueInShop.Dequeue();
            Console.WriteLine($"Klijent je platio... idemo dalje {queueInShop.Peek()} je na redu");

            foreach (string element in queueInShop)
                Console.WriteLine(element);

            Console.WriteLine("------------------------- Stack --------------------");

            Stack<string> cookies = new Stack<string>();

            cookies.Push("Prvi keks");
            cookies.Push("Drugi keks");
            cookies.Push("Treci keks");
            cookies.Push("Cetvrti keks");
            cookies.Push("Peti keks");

            Console.WriteLine("Cookies: ");
            foreach (string element in cookies)
                Console.WriteLine(element);

            cookies.Pop();
            Console.WriteLine($"Keks je izvadjen... idemo dalje naredni je {cookies.Peek()}");

            Console.WriteLine("Cookies: ");
            foreach (string element in cookies)
                Console.WriteLine(element);

            cookies.Pop();
            cookies.Pop();
            Console.WriteLine($"Dva keksa su izvadjena... idemo dalje naredni je {cookies.Peek()}");

            Console.WriteLine("Cookies: ");
            foreach (string element in cookies)
                Console.WriteLine(element);

            Console.WriteLine("Exercies ----------------------------------------------------------------");

            Dictionary<string, long> phoneBook = new Dictionary<string, long>()
            {
                {"Bob", 70993241 },
                {"Will", 71234232 },
                {"Meg", 72778900 },
                {"Jill", 71562110 },
                {"Buck", 71119804 }
            };

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            PrintPhone(phoneBook, name);

            // Drugi zadatak
            List<Person> FansArray = new List<Person>();

            //fans
            Person Jerry = new Person("Jerry", "Tompson", 78, Genre.Rock);
            Person Stefan = new Person("Stefan", "Stefanoski", 28, Genre.Techno);
            Person Maria = new Person("Maria", "Campbel", 43, Genre.Classical);
            Person Jane = new Person("Jane", "Doe", 28, Genre.Techno);

            //songs
            Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
            Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
            Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
            Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
            Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
            Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
            Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
            Song song10 = new Song("Fight the Power", 321, Genre.Techno);
            Song song11 = new Song("The Message", 363, Genre.Techno);
            Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
            Song song13 = new Song("No Fear", 182, Genre.Techno);
            Song song14 = new Song("Hereditary", 340, Genre.Techno);
            Song song15 = new Song("Bounce Back", 226, Genre.Techno);
            Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
            Song song17 = new Song("Canon in D major", 376, Genre.Classical);
            Song song18 = new Song("Swan Lake", 461, Genre.Classical);
            Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
            Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
            Song song23 = new Song("Planet E", 420, Genre.Techno);
            Song song24 = new Song("Phasor", 368, Genre.Techno);
            Song song25 = new Song("Counting Comets", 242, Genre.Techno);
            Song song26 = new Song("Cold Summer", 358, Genre.Techno);
            Song song27 = new Song("Destroyer", 359, Genre.Techno);
            Song song28 = new Song("Phalanx", 307, Genre.Techno);
            Song song29 = new Song("Vision", 693, Genre.Techno);
            Song song30 = new Song("Chain Reaction", 181, Genre.Techno);

            List<Song> Songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
            song8, song9, song10, song11, song12, song13, song14, song15,
            song16, song17, song18, song19, song20, song21, song22, song23,
            song24, song25, song26, song27, song28, song29, song30 };

            FansArray.Add(Jerry);
            FansArray.Add(Stefan);
            FansArray.Add(Maria);
            FansArray.Add(Jane);

            Person stefanPerson = FansArray
                 .Where(p => p.FirstName == "Stefan" && p.Age == 26)
                 .First();
        }

        private static void PrintPhone(Dictionary<string, long> phoneBook, string? name)
        {
            if (phoneBook.ContainsKey(name) == false)
            {
                Console.WriteLine($"There is no {name} in this phoneBook. Sorry!");
                return;
            }

            Console.WriteLine($"{name}'s phone is: 0{phoneBook[name]}");
        }

    }
}
