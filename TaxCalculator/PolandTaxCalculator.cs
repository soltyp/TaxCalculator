using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class PolandTaxCalculator : TaxCalculatorBase
    {
        private decimal firstThreshold = 120000m; // Prog podatkowy od 2023 roku
        private decimal lowRate = 0.12m; // Stawka podatkowa dla pierwszego progu
        private decimal highRate = 0.32m; // Stawka podatkowa powyżej pierwszego progu

        public override decimal CalculateTax(decimal income)
        {
            if (income <= firstThreshold)
            {
                return income * lowRate;
            }
            else
            {
                return firstThreshold - 108000m + (income - firstThreshold) * highRate;
            }
        }
    }

}
