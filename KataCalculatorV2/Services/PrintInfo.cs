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

        public PrintInfo(ITax tax)
        {
            this.tax = tax;
        }

        public void Print(CalculatorModules calculator)
        {
            PrintInfo printInfo = new PrintInfo(tax);

            Console.WriteLine($"Book name = {calculator.ProductName} , UPC = {calculator.UPC} , Price = {calculator.price.ToString("C2")}\n"+
                $", Price before tax {calculator.price.ToString("C2")} and after {calculator.taxValue} % tax ( {printInfo.tax.TaxAmount(calculator).ToString("C2")} ) .\n" +
                $"And Price after tax = {printInfo.tax.priceAfterTax(calculator).ToString("C2")}");
        }
    }
}
