﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingsAccount : Account
    {
        public SavingsAccount()
        {

        }

        public override double Deposit(double depValue)
        {
            return Balance += depValue;
        }

        public override bool Withdraw(double value)
        {
            return base.Withdraw(value + 0.10);
        }
    }
}
