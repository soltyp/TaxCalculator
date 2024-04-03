using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public abstract class TaxCalculatorBase
    {
        public abstract decimal CalculateTax(decimal income);
    }
}
