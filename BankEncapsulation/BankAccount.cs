using System;


namespace BankEncapsulation
{
    //Created a class called BankAccount
    public class BankAccount
    {
        // Created a private field called _balance
        private double _balance;
        public double balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = 0;
            }
            
        }
        
        // Created the method GetBalance and set it to return _balance
        public double GetBalance()
        {
            return balance;
        }
        // Created the method deposit and set it to accept a value of double named balance
        public void Deposit(double balance)
        {
            _balance += balance;
        }
        
    }
}
