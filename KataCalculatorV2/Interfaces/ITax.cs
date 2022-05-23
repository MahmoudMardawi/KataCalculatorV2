using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2
{
    internal interface ITax
    {
        public decimal priceAfterTax(CalculatorModel calculator);
        public decimal TaxAmount(CalculatorModel calculator);

    }
}
