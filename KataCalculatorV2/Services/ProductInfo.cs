using KataCalculatorV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Services
{
    internal class ProductInfo : IProductInfo
    {
        CalculatorModel calculatorModel;
        public ProductInfo(CalculatorModel calculatorModel)
        {
            this.calculatorModel = calculatorModel;
        }
        public string ProductName() => calculatorModel.ProductName;
        public decimal Price() => calculatorModel.Price;
        public int UPC() => calculatorModel.UPC;
        public decimal TaxValue()=> calculatorModel.TaxValue;
        public decimal DiscountValue() => calculatorModel.DiscountValue;
    }
}
