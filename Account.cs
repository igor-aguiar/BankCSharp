using System;

namespace Bank
{
    public abstract class Account
    {
        public Account()
        {
        }

        public int Number { get;  set; }
        public double Balance { get;  set; }
        public Client Owner { get; set; }

        public abstract double Deposit(double depValue);

        public virtual bool Withdraw(double value)
        {
            if (Balance >= value)
            {
                Balance -= value;
                return true;
            }
            else
            {
                throw new Exception("The value it's greater than the balance.");
            }
            
        }
    }
}