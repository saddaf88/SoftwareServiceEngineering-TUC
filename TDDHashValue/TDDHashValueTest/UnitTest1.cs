using System;
using Xunit;
using TDDHashValue;

namespace TDDHashValueTest
{
    public class UnitTest1
    {
        [Fact]
        public void HashValueTest()
        {
            var hashVal = new HashValue();
            var result = hashVal.GetHashValue("VSR");
            Assert.Equal(124, result);
        }

        [Fact]
        public void HashValueEmptyStringTest()
        {
            var hashVal = new HashValue();
            var result = hashVal.GetHashValue("");
            Assert.Equal(-1, result);
        }

    }
}
