using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class GermanyTaxCalculator : TaxCalculatorBase
    {
        public override decimal CalculateTax(decimal incomeEur)
        {
            if (incomeEur <= 9984)
            {
                return 0;
            }
            else if (incomeEur <= 58596)
            {
                decimal baseTax = (incomeEur - 9984) * 0.14m; 
                return baseTax;
            }
            else if (incomeEur <= 277825)
            {
                decimal taxForSecondBracket = (58596 - 9984) * 0.14m;
                return taxForSecondBracket + (incomeEur - 58596) * 0.42m;
            }
            else
            {
                decimal taxForSecondBracket = (58596 - 9984) * 0.14m;
                decimal taxForThirdBracket = (277825 - 58596) * 0.42m;
                return taxForSecondBracket + taxForThirdBracket + (incomeEur - 277825) * 0.45m;
            }
        }
    }
}
