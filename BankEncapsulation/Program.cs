using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created a new instance of the BankAccount class
            var account = new BankAccount();
            
            // Gets the amount to deposit into account
            Console.WriteLine("What is your deposit amount?");
            
            // Creating a var to hold the amount of the deposit once it is read
            var amountToDeposit = double.Parse(Console.ReadLine());

            // Gets the amount to deposit and puts it into Deposit
            account.Deposit(amountToDeposit);
            
            // Tells the account holder the balance of their account after deposit
            Console.WriteLine($"Your current balance is {account.GetBalance()}");
        }
    }
}