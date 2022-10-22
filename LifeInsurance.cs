using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class LifeInsurance : ITaxable
    {
        public double CalculateTax()
        {
            return 42.0;
        }
    }
}
