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
            Tax tax = new Tax();
            PrintInfo printInfo = new PrintInfo(tax);
            DataInputUtilities.dataInputUtilities(calculatorModels);

            printInfo.Print(calculatorModels);
        }
    }
}
