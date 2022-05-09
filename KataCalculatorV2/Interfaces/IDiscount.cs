using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Interfaces
{
    internal interface IDiscount
    {
        public double discountAmount(CalculatorModel calculator);
        public double priceAfterdiscount(CalculatorModel calculator);

    }
}
