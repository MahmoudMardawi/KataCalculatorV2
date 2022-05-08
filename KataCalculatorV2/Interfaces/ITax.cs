using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2
{
    internal interface ITax
    {
        public double priceAfterTax(CalculatorModules calculator);
        public double TaxAmount(CalculatorModules calculator);

    }
}
