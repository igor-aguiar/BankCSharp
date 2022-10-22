using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CurrentAccount : Account
    {
        public CurrentAccount()
        {
        }

        public override bool Withdraw(double value)
        {
            return base.Withdraw(value + 0.11);
        }
    }
}
