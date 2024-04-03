using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class USATaxCalculator : TaxCalculatorBase
    {
        public override decimal CalculateTax(decimal annualIncome)
        {
            decimal tax = 0m;

            if (annualIncome <= 9950)
            {
                tax = annualIncome * 0.10m;
            }
            else if (annualIncome <= 40525)
            {
                tax = 995 + (annualIncome - 9950) * 0.12m;
            }
            else if (annualIncome <= 86375)
            {
                tax = 4664 + (annualIncome - 40525) * 0.22m;
            }
            else if (annualIncome <= 164925)
            {
                tax = 14751 + (annualIncome - 86375) * 0.24m;
            }
            else if (annualIncome <= 209425)
            {
                tax = 33603 + (annualIncome - 164925) * 0.32m;
            }
            else if (annualIncome <= 523600)
            {
                tax = 47843 + (annualIncome - 209425) * 0.35m;
            }
            else
            {
                tax = 157804.25m + (annualIncome - 523600) * 0.37m;
            }

            return tax;
        }
    }
}
