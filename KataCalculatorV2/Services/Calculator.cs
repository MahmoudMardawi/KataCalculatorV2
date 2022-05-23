using KataCalculatorV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Services
{
    internal class Calculator
    {
        ITax tax;
        IDiscount discount;
        public Calculator(ITax tax, IDiscount discount)
        {
            this.tax = tax;
            this.discount = discount;
        }
        public decimal PriceAfterTax(CalculatorModel calculatorModel)
        {
            decimal result = tax.priceAfterTax(calculatorModel);
            return result;
        }
        public decimal TaxAmount(CalculatorModel calculatorModel)
        {
            decimal result = tax.TaxAmount(calculatorModel);
            return result;
        } 
        public decimal 
       
    }
}
