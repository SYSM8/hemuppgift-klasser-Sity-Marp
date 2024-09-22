using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //fields
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        //Konstruktor
        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;

        }

        //account deposit
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0)
            {
                Balance += depositAmount;
                //the :C within the variable brackets uses system locale to format numbers & print the right currency symbol
                Console.WriteLine($"Deposited {depositAmount:C}, new balance is {Balance:C}.");
            }
            else
            {
                Console.WriteLine("invalid input.");
            }
        }


        //account withdrawal
        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount <= Balance && withdrawAmount > 0)
            {
                Balance -= withdrawAmount;
                Console.WriteLine($"Withdrew {withdrawAmount:C}, new balance is {Balance:C}.");
            }
            else
            {
                Console.WriteLine("Can't make withdrawals larger than your current balance.");
            }
        }


        // account balance display
        public void DisplayBalance()
        {
            Console.WriteLine($"Your balance is: {Balance:C}");
        }

    }
}
