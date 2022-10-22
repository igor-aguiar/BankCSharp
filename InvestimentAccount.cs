using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class InvestimentAccount : Account
    {
        public override double Deposit(double depValue)
        {
            return this.Balance += depValue;
        }

        public override bool Withdraw(double value)
        {
            return base.Withdraw(value);
        }


    }
}
