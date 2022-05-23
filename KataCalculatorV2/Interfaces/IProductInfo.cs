using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Interfaces
{
    internal interface IProductInfo
    {
        public string ProductName();
        public decimal Price();
        public int UPC();
        public decimal TaxValue();
        public decimal DiscountValue();
    }
}
