using System;

namespace Bank
{
    public class Account
    {
        public Account()
        {
        }

        public int Number { get;  set; }
        public double Balance { get;  set; }
        public Client Owner { get; set; }

        public double Deposit(double depValue)
        {
            return Balance += depValue;
        }

        public bool Withdraw(double value)
        {
            if (Balance >= value)
            {
                Balance -= value;
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}