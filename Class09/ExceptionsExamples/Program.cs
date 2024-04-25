using ExceptionsExamples.Exceptions;

namespace ExceptionsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any number> ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Korijen broja je> {SquareRoot(number)}");

                double result = 10 / number;

                List<int> list = null;

                int[] numbersArray = new int[5];
                numbersArray[10] = 10;

                list.Add(number);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("It seems like there is an error with data please try again");
            }
            catch (FormatException ex) 
            { 
                Console.WriteLine("It seems like your input was not in a correct form, please try again");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("It seems like you tried to divide by zero, please try again");
            }
            catch (QinshiftAcademyException ex)
            {
                Console.WriteLine($"Out custom exception was catched....{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some weird error happened, please try again");
            }

            finally
            {
                // Console.WriteLine("THIS PART OF THE CODE WILL ALWAYS EXECUTE");
            }
            
            Console.WriteLine("The code reached this line ::::::::::::");
        }

        static double SquareRoot(double x)
        {
            if (x < 0)
                throw new QinshiftAcademyException("Korjenovanje sa negativnim brojem je zabranjeno");

            return Math.Sqrt(x);
        }
    }
}
