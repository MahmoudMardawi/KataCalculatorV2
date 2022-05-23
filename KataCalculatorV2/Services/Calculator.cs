using KataCalculatorV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Services
{
    internal class Calculator
    {
       
        IProductInfo productInfo;
        public Calculator(IProductInfo productInfo)
        {
   
            this.productInfo = productInfo;
        }
        public decimal PriceAfterTax()
        {
            decimal result = TaxAmount() + productInfo.Price();
            return result;
        }
        public decimal TaxAmount()
        {
            return productInfo.TaxValue() * productInfo.Price() / 100;
        } 
        public decimal PriceAfterDiscount()
        {
            return  productInfo.Price() - DiscountAmount();
          
        } 
        public decimal DiscountAmount()
        {
            return productInfo.Price() * productInfo.DiscountValue()/100;
        }
        public decimal TotalPrice()
        {
            return productInfo.Price() + TaxAmount() - DiscountAmount();
        }
    }
}
