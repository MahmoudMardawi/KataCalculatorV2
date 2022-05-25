using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Interfaces
{
    public interface ICalculator
    {
  
        public decimal PriceAfterTax();
        public decimal TaxAmount();
        public decimal PriceAfterDiscount();
        public decimal DiscountAmount();
        public decimal TotalPrice();
    }
}
