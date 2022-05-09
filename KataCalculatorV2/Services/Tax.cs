using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2
{
    internal class Tax : ITax
    {
        public  double priceAfterTax(CalculatorModel calculator) => (calculator.price*calculator.taxValue / 100) + calculator.price;
        public  double TaxAmount(CalculatorModel calculator) => calculator.price * calculator.taxValue / 100;
    }
}
