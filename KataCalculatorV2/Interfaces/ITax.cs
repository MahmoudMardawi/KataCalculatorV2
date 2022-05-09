using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2
{
    internal interface ITax
    {
        public double priceAfterTax(CalculatorModels calculator);
        public double TaxAmount(CalculatorModels calculator);

    }
}
