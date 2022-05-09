using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2
{
    internal class CalculatorModel
    {
        public double taxValue { get; set; }
        public string ProductName { get; set; }
        public int UPC { set; get; }
        public double price { set; get; }
        public double discountValue { get; set; }
    }
}
