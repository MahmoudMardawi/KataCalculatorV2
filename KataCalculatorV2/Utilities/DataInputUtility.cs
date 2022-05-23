using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Modules
{
    internal class DataInputUtility
    {
        public static CalculatorModel dataInputUtility()
        {
            return new CalculatorModel
            {
                TaxValue = 17,
                ProductName = "Test",
                UPC = 1234,
                Price = 25,
                DiscountValue = 25

            };


        }
    }
}
