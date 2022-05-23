using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2
{
    internal class CalculatorModel
    {
        public decimal TaxValue { get; set; }
        public string ProductName { get; set; }
        public int UPC { set; get; }
        public decimal Price { set; get; }
        public decimal DiscountValue { get; set; }
    }
}
