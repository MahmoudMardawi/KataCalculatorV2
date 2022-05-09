using KataCalculatorV2.Modules;
using KataCalculatorV2.Services;
using System;
namespace KataCalculatorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorModels calculatorModels = new CalculatorModels();
            Discount discount = new Discount();
            Tax tax = new Tax();
            PrintInfo printInfo = new PrintInfo(tax,discount);
            DataInputUtilities.dataInputUtilities(calculatorModels);

            printInfo.Print(calculatorModels);
        }
    }
}
