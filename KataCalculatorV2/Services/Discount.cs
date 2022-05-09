using KataCalculatorV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Services
{
    internal class Discount : IDiscount
    {
        public double discountAmount(CalculatorModels calculator) => calculator.price * calculator.discountValue / 100; 
        public double priceAfterdiscount(CalculatorModels calculator) => discountAmount(calculator)-calculator.price;
    }
}
