﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Modules
{
    internal class DataInputUtilities
    {
        public static void dataInputUtilities(CalculatorModels calculator)
        {
            calculator.taxValue = 17.5;
            calculator.price = 25;
            calculator.UPC = 1234;
            calculator.discountValue = 20;
            calculator.ProductName = "TEST";

        }
    }
}
