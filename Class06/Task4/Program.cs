using Task4.Models;

namespace Task4
{
    internal class Program
    {
        static Customer[] customers = new Customer[]
        {
          new Customer("Bob","Bobsky", 1234123412341234, 1234, 750),
          new Customer("Jill","Wayne", 8235823582358235, 9000, 1200),
          new Customer("Rayan","Dawn", 0090119122923393, 2500, 500),
          new Customer("Anne","May", 0000220311012203, 0000, 400)
        };

        static void Main()
        {
            while (InitATM(customers) == false)
                Console.Clear();

            Console.WriteLine("Have a nice day!");
            Console.ReadLine();
        }

        #region Methods

        static bool ChooseOption(Customer customer)
        {
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("1) Check Balance");
            Console.WriteLine("2) Cash Withdrawal");
            Console.WriteLine("3) Cash Deposit");
            Console.WriteLine("4) Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(string.Format("Your balance is: {0:C}", customer.CheckAccount()));
                    break;
                
                case 2:
                    Console.WriteLine("How much would you like to withdraw?");
                   
                    int ammountW = 0;
                   
                    bool withdrawl = customer.WithdrawFromAccount(ammountW);

                    if (withdrawl == false) 
                        Console.WriteLine("You don't have enough money on your account!");
                    else 
                        Console.WriteLine(string.Format("You withdrawed {0:C}. You have {1:C} left on your account.", ammountW, customer.CheckAccount()));
                    break;

                case 3:
                    Console.WriteLine("Enter ammount of deposit:");
                    int ammountD = 0;
                    
                    customer.DepositToAccount(ammountD);
                    Console.WriteLine(string.Format("You deposited {0:C}. You have {1:C} on your account.", ammountD, customer.CheckAccount()));
                    break;
                case 4:

                    return true;
                default:
                    Console.WriteLine("The number should be one of the options. Please try again.");
                    return false;
            }

            Console.WriteLine("Enter anything for another action or X to exit... ");
            
            if (Console.ReadLine().ToUpper() != "X") 
                return false;
            
            return true;
        }

        static Customer FindCustomer(Customer[] customers, long cardNumber)
        {
            foreach (Customer customer in customers)
                if (customer.CardNumber == cardNumber) 
                    return customer;

            return null;
        }

        static long FormatCardNumber(string stringNumber)
        {
            string[] numbers = stringNumber.Split('-');

            if (numbers.Length != 4)
                return -1;

            long number = -1;

            bool isNumber = long.TryParse(numbers[0] + numbers[1] + numbers[2] + numbers[3], out number);

            if (!isNumber)
                return -1;

            return number;
        }

        static bool InitATM(Customer[] customers)
        {
            Console.WriteLine("Welcome to the ATM App");
            Console.WriteLine("Please enter your card number");

            long cardNumber = FormatCardNumber(Console.ReadLine());

            if (cardNumber == -1)
            {
                Console.WriteLine("Your card number is incorrect. Enter anything to try again.");
                Console.ReadLine();
                return false;
            }

            Customer customer = FindCustomer(customers, cardNumber);

            if (customer == null)
            {
                Console.WriteLine("That customer does not exist. Enter anything to try again.");
                Console.ReadLine();
                return false;
            }

            Console.WriteLine("Please enter your PIN:");

            short pin = Convert.ToInt16(Console.ReadLine());

            if (customer.CheckPin(pin) == false)
            {
                Console.WriteLine("The pin was not correct. Enter anything to try again.");
                Console.ReadLine();
                return false;
            }

            Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName}!");

            while (!ChooseOption(customer))
                Console.Clear();

            Console.WriteLine("Enter X to exit the application or anything to login as another user.");

            if (Console.ReadLine().ToUpper() == "X")
                return true;

            return false;
        }

        #endregion
    }
}