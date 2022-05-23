using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2
{
    internal class Tax : ITax
    {
        public  decimal priceAfterTax(CalculatorModel calculator) => (calculator.Price*calculator.TaxValue / 100) + calculator.Price;
        public  decimal TaxAmount(CalculatorModel calculator) => calculator.Price * calculator.TaxValue / 100;
    }
}
