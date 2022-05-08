using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Interfaces
{
    internal interface IDiscount
    {
        public double discountValue(CalculatorModels calculator);
        public double discountAmount(CalculatorModels calculator);
        public double priceAfterdiscount(CalculatorModels calculator);
    }
}
