using KataCalculatorV2.Services;
using KataCalculatorV2.Interfaces;
using Moq;
using FluentAssertions;

namespace KataCalculator.Tests
{
    public class CalculatorTests
    {
        private readonly Mock<IProductInfo> productInfo;
        private readonly Calculator calculator;

        public CalculatorTests()
        {
            productInfo = new Mock<IProductInfo>();
            calculator = new Calculator(productInfo.Object);
        }



        [Fact]
        public void ShouldReturnTaxAmount()
        {
            productInfo.Setup(i => i.TaxValue()).Returns(100);
            productInfo.Setup(i => i.Price()).Returns(50);
            var result = calculator.TaxAmount();
            result.Should().Be(50);
        }

        [Fact]
        public void ShouldReturnPriceAfterAddingTax()
        {
            productInfo.Setup(i => i.TaxValue()).Returns(100);
            productInfo.Setup(i => i.Price()).Returns(50);
            //calculator.TaxAmount().Should().Be(50);
            var result = calculator.PriceAfterTax();
            result.Should().Be(100);
        }
        [Fact]
        public void ShouldReurnDiscountAmount()
        {
            productInfo.Setup(i => i.DiscountValue()).Returns(20);
            productInfo.Setup(i => i.Price()).Returns(50);
            var result = calculator.DiscountAmount();
            result.Should().Be(10);

        }
        [Fact]
        public void ShouldReurnThePriceAfterDiscount()
        {
            productInfo.Setup(i => i.DiscountValue()).Returns(20);
            productInfo.Setup(i => i.Price()).Returns(50);
            var result = calculator.PriceAfterDiscount();
            result.Should().Be(40); 
        }
        [Fact]
        public void ShouldReturnThePriceAfterAddTaxAndDiscount()
        {
            productInfo.Setup(i => i.TaxValue()).Returns(100);
            productInfo.Setup(i => i.DiscountValue()).Returns(20);
            productInfo.Setup(i => i.Price()).Returns(50);
            var result = calculator.TotalPrice();
            result.Should().Be(90);
        }
    }
}
