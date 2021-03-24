using System;


namespace BankEncapsulation
{
    //Created a class called BankAccount
    public class BankAccount
    {
        public BankAccount()
        {
        }
        
        // Created a private field called _balance
        private double _balance = 0;

        // Created the method deposit and set it to accept a value of double named balance
        public void Deposit(double amount)
        {
            _balance = amount;
        }
        
        // Created the method GetBalance and set it to return _balance
        public double GetBalance()
        {
            return _balance;
        }
       
        
    }
}
