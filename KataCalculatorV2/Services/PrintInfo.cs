using KataCalculatorV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Services
{
    public class PrintInfo
    {
        ICalculator calculator;
        IProductInfo productInfo;
        public PrintInfo (ICalculator calculator, IProductInfo productInfo)
        {
            this.calculator = calculator;
            this.productInfo = productInfo;
        }

        public void Print()
        {

            Console.WriteLine($"Book name = {productInfo.ProductName()} , UPC = {productInfo.UPC()} , Price = {productInfo.Price()}\n"+
                $"Tax = {productInfo.TaxValue()}%, Discount = {productInfo.DiscountValue()}% "+
                $", Tax Amount = {calculator.TaxAmount().ToString("C2")}" +
                $", Discount Amount = {calculator.DiscountAmount().ToString("C2")}\n" +
                $"Price before = {productInfo.Price().ToString("C2")}, Price after = {calculator.TotalPrice().ToString("C2")}");
        }
    }
}
