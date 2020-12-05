using Xunit;
using TDDCalculator;

namespace TDDCalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void MultiplyTest()
        {
            var cal = new Calculator ();
            var result = cal.Multiply(3, 5);
            Assert.Equal(15, result);

        }
    }
}
