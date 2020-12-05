using System;
using Xunit;
using TDDCalculator;


namespace TDDCal
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

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
