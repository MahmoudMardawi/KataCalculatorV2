using KataCalculatorV2.Modules;
using KataCalculatorV2.Services;
using System;

namespace KataCalculatorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorModules calculatorModules = new CalculatorModules();
            Tax tax = new Tax();
            PrintInfo printInfo = new PrintInfo(tax);
            DataInputUtilities.dataInputUtilities(calculatorModules);

            printInfo.Print(calculatorModules);
            
        }
    }
}
