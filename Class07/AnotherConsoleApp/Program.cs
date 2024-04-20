using CommonModels.Enums;
using CommonModels.Models;

namespace AnotherConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student almir = new Student();
            
            almir.FirstName = "Almir";
            almir.LastName = "Vuk";
            almir.Gender = Gender.Male;

            almir.PrintInfo();

            almir.NewInformationField = "NEW INFO";
        }
    }
}
