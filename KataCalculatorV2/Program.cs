using KataCalculatorV2.Modules;
using KataCalculatorV2.Services;
using System;
namespace KataCalculatorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorModel calculatorModels = DataInputUtility.dataInputUtility();
            // Product Object. => Product Main Details (Name, UPC, Price). 
            // Calcolator (DiscountService, TaxService)  => 
            // Calculator.CalculatePruice(Product) => PriceDetails (FinalPrice, Discount, Tax) 
            // Printer => printPriceDetails. 
            
            // 

            Discount discount = new Discount();
            Tax tax = new Tax();
            PrintInfo printInfo = new PrintInfo(tax,discount);

            printInfo.Print(PriceDetails);
        }
    }
}
