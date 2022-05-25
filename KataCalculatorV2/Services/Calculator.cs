using KataCalculatorV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Services
{
    public class Calculator : ICalculator
    {
       
        IProductInfo productInfo;
        

        public Calculator(IProductInfo productInfo)
        {
            this.productInfo = productInfo;
        }

        

        public decimal PriceAfterTax()
        {
           return TaxAmount() + productInfo.Price();
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
