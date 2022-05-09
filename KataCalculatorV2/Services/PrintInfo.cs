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
        IDiscount discount;

        public PrintInfo(ITax tax, IDiscount discount)
        {
            this.tax = tax;
            this.discount = discount;
        }
        //public PrintInfo(IDiscount discount)
        //{
        //    this.discount = discount;
        //}

        public void Print(CalculatorModel calculator)
        {
            double priceAfterTax = tax.priceAfterTax(calculator);
            double taxAmount = tax.TaxAmount(calculator);
            double discountAmount = discount.discountAmount(calculator);
            double totalPrice = priceAfterTax - discountAmount;
            Console.WriteLine($"Book name = {calculator.ProductName} , UPC = {calculator.UPC} , Price = {calculator.price.ToString("C2")}\n"+
                $"Tax = {calculator.taxValue}%, Discount = {calculator.discountValue}%, Tax Amount = {taxAmount.ToString("C2")}" +
                $", Discount Amount = {discountAmount.ToString("C2")}\n" +
                $"Price before = {calculator.price.ToString("C2")}, Price after = {totalPrice.ToString("C2")}");
        }
    }
}
