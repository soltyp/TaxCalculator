using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class UKTaxCalculator : TaxCalculatorBase
    {
        public override decimal CalculateTax(decimal income)
        {
            
            if (income <= 12570)
            {
                return 0;
            }
            else if (income <= 50270)
            {
                return income  * 0.20m; 
            }
            else if (income <= 150000)
            {
                return income * 0.40m; 
            }
            else
            {
                return income * 0.45m; 
            }
        }
    }
}
