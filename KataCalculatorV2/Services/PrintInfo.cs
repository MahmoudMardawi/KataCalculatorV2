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

        public  void Print(CalculatorModules calculator)
        {
            
            Console.WriteLine(tax.priceAfterTax(calculator).ToString());
        }
    }
}
