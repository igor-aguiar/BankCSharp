using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CurrentAccount : Account, ITaxable
    {
        public CurrentAccount()
        {
        }

        public double CalculateTax()
        {
            return this.Balance -= Balance * 0.05;
        }

        public override double Deposit(double depValue)
        {
            return Balance += depValue;
        }

        public override bool Withdraw(double value)
        {
            return base.Withdraw(value + 0.11);
        }
    }
}
