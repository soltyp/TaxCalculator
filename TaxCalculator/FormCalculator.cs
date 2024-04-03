using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaxCalculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }




        private void calculateButton_Click(object sender, EventArgs e)
        {
            string currency = "default";
            TaxCalculatorBase? calculator = null;
            if (countryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a country from the list.");
                return;
            }
            if (!decimal.TryParse(incomeTextBox.Text, out decimal income) || income < 0)
            {
                MessageBox.Show("Proszę wprowadzić prawidłową kwotę dochodu.");
                return;
            }
           


            switch (countryComboBox.SelectedItem.ToString())
            {
                case "France":
                    calculator = new FranceTaxCalculator();
                    currency = "EUR";
                    break;
                case "Germany":
                    calculator = new GermanyTaxCalculator();
                    currency = "EUR";
                    break;
                case "United Kingdom":
                    calculator = new UKTaxCalculator();
                    currency = "GBP";
                    break;
                case "Poland":
                    calculator = new PolandTaxCalculator();
                    currency = "PLN";
                    break;
                case "USA":
                    calculator = new USATaxCalculator();
                    currency = "USD";
                    break;
                default:
                    // Możesz obsłużyć sytuację, gdy żaden przypadek nie pasuje
                    MessageBox.Show("Please select a valid country.");
                    break;
            }

                
            if (calculator != null)
            {
                decimal tax = calculator.CalculateTax(income);
                decimal netIncome = income - tax;
                string tax1 = tax.ToString("N0");
                string netIncome1 = netIncome.ToString("N0");
                taxResultLabel.Text = $"Tax: {tax1} {currency}";
                netIncomeResultLabel.Text = $"Net income: {netIncome1} {currency}";
            }
        }


    }
}
