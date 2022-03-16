using System;

namespace Unit_Tests_and_Documentation
{
     public class Program
    {
        public static decimal Balance = 5000;
        public static void UserInterface()
        {
            while (true)
            {
                Console.WriteLine("Thanks for using our Bank ");
                Console.WriteLine("____________ATM____________ ");
                Console.WriteLine("Please select Your Operation ");
                Console.WriteLine("1:  View my Balance ");
                Console.WriteLine("2:  Deposit Money ");
                Console.WriteLine("3:  Draw Money  ");
                Console.WriteLine("0:  Exit  ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    Console.WriteLine("Thanks for using our Bank ");
                    break;
                }
                switch (input)
                {
                    case 1:
                        
                        Console.WriteLine("Your Balance is: " + ViewBalance());
                        break;
                         
                    case 2:
                        
                        Console.WriteLine("Please enter value to deposit it");
                        decimal depositInput = Convert.ToDecimal(Console.ReadLine());
                        Deposit(depositInput);
                        Console.WriteLine("Your Balance is: " + ViewBalance());
                        break;
                    case 3:
                        Console.WriteLine("Please enter value to draw it");
                        decimal drawInput = Convert.ToDecimal(Console.ReadLine());
                        Withdraw(drawInput);
                        Console.WriteLine("Your Balance is: " + ViewBalance());
                        break ;    
                }  
            }
        }
        public static decimal ViewBalance()
        {
            return Balance;
        }
        public static decimal Withdraw(decimal money)
        {
            if (money < 0) Console.WriteLine("You entered unvalid value ");
            else if (money > Balance) Console.WriteLine("You entered value greater than your balance ");
            else Balance -= money;
            return Balance;
        }
        public static decimal Deposit(decimal money)
        {
            if (money < 0) Console.WriteLine("You entered unvalid value ");
            else Balance += money;
            return Balance;
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    UserInterface();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You entered unvalid value ");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                break;
            }
        }
    }
}
