using Moq;
using Xunit;
using TDDCalculator;
using System.IO;

namespace TDDCalculatorTest
{
    public class MockCalculatorTest
    {
        private IResultWriter _resultWriter;

        public MockCalculatorTest()
        {
            var mock = new Mock<IResultWriter>();
            mock.Setup(o => o.WriteResult(It.IsAny<double>()));
            _resultWriter = mock.Object;
        }

        [Fact]
        public void TestMultiply()
        {
            var c = new MockCalculator(_resultWriter);
            var result = c.Multiply(3, 2);
            Assert.Equal(result, 6);
        }

        [Fact]
        public void TestDivide()
        {
            var c = new MockCalculator(_resultWriter);
            var result = c.Divide(6, 3);
            Assert.Equal(result, 2);
        }

        [Fact]
        public void TestDivideByZero()
        {
            var c = new MockCalculator(_resultWriter);
            var result = c.Divide(6, 0);
            Assert.Equal(result, double.NaN);
        }

        [Fact]
        public void TestException()
        {
            var mock = new Mock<IResultWriter>();
            mock.Setup(o => o.WriteResult(It.IsAny<double>())).Throws(new IOException("Disk is full"));

            var c = new MockCalculator(mock.Object);
            Assert.Throws<IOException>(() => c.Multiply(3, 2));
        }

    }
}
