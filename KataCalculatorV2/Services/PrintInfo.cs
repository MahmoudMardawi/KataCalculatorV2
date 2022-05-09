using KataCalculatorV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorV2.Services
{
    internal class PrintInfo
    {
        ITax tax;
       // IDiscount discount
        public PrintInfo(ITax tax)
        {
            this.tax = tax;
        }
        
        public void Print(CalculatorModels calculator)
        {
            Console.WriteLine($"Book name = {calculator.ProductName} , UPC = {calculator.UPC} , Price = {calculator.price.ToString("C2")}\n"+
                $", Price before tax {calculator.price.ToString("C2")} and after {calculator.taxValue} % tax ( {tax.TaxAmount(calculator).ToString("C2")} ) .\n" +
                $"And Price after tax = {tax.priceAfterTax(calculator).ToString("C2")}");
        }
    }
}
