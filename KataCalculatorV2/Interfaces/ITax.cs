using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2
{
    internal interface ITax
    {
         double priceAfterTax(CalculatorModels calculator);
         double TaxAmount(CalculatorModels calculator);
    }
}
