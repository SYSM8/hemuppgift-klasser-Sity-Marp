using System.Data;
using System.Security.AccessControl;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates an instance/object of the BankAccount class with help of the constructor to initialize the object with values.
            BankAccount account = new BankAccount("123456789", "John Doe", 1000);

            //BankAccount methods usage test
            //account.Deposit(500);
            //account.Withdraw(200);
            //account.DisplayBalance();

            bool mainLoop = true;

            while (mainLoop)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Bank Account\n1: Display Balance\n2: Withdraw\n3: Deposit\n4: Exit");
                    decimal userInput = Convert.ToDecimal(Console.ReadLine());


                    switch (userInput)
                    {
                        case 1:
                            account.DisplayBalance();
                            break;

                        case 2:
                            Console.Write("Enter withdrawal amount: ");
                            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                            account.Withdraw(withdrawAmount);
                            break;

                        case 3:
                            Console.Write("Enter deposit amount: ");
                            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                            account.Deposit(depositAmount);
                            break;

                        case 4:
                            Console.WriteLine("exiting..");
                            mainLoop = false;
                            break;

                        default:
                            Console.WriteLine("invalid choice.");
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("try numbers.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("numbers entered either too big or small.");
                }

                if (mainLoop)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }

            }
        }
    }
}
