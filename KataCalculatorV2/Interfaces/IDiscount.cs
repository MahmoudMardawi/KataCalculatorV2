using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Interfaces
{
    internal interface IDiscount
    {
        public decimal DiscountValue(CalculatorModel calculator);
    }
}
