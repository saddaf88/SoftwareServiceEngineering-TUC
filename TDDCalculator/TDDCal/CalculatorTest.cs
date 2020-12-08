using TDDCalculator;
using Xunit;

namespace TDDCal
{
    public class CalculatorTest
    {
        [Fact]
        public void MultiplyTest()
        {
            var cal = new Calculator();
            var result = cal.Multiply(3, 5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void DivisionTest()
        {
            var cal = new Calculator();
            var result = cal.Division(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void DivisionByZeroTest()
        {
            var cal = new Calculator();
            var result = cal.Division(10, 0);
            Assert.Equal(double.NaN, result);
        }
    }
}
