using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Modules
{
    internal class DataInputUtilitiey
    {
        public static void dataInputUtilities(CalculatorModels calculator)
        {
            calculator.ProductName = "Test";
            calculator.taxValue = 17.3;
            calculator.price = 25.0;
            calculator.UPC = 1234;
            calculator.discountValue = 15.0;
        }
    }
}
