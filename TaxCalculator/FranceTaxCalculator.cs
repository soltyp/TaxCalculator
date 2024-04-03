using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class FranceTaxCalculator : TaxCalculatorBase
    {
        public override decimal CalculateTax(decimal annualIncome)
        {
            decimal tax = 0m;

            if (annualIncome <= 10064)
            {
                tax = 0;
            }
            else if (annualIncome <= 25659)
            {
                tax += (annualIncome - 10064) * 0.11m;
            }
            else if (annualIncome <= 73369)
            {
                tax += (25659 - 10064) * 0.11m;
                tax += (annualIncome - 25659) * 0.30m;
            }
            else if (annualIncome <= 157806)
            {
                tax += (25659 - 10064) * 0.11m;
                tax += (73369 - 25659) * 0.30m;
                tax += (annualIncome - 73369) * 0.41m;
            }
            else
            {
                tax += (25659 - 10064) * 0.11m;
                tax += (73369 - 25659) * 0.30m;
                tax += (157806 - 73369) * 0.41m;
                tax += (annualIncome - 157806) * 0.45m;
            }

            return tax;
        }

    }
}
