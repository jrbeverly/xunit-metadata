using System;
using Xunit.Metadata.Management;

namespace Xunit.Metadata.Sample.Management
{
    [Bug("ABC")]
    [Epic("ABC")]
    [Feature("ABC")]
    [Improvement("ABC")]
    [Issue("ABC")]
    [Story("ABC")]
    public class AdderDivideTests
    {
        public AdderDivideTests()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Theory]
        [InlineData(2, 2)]
        [InlineData(10, 1)]
        public void GivenPositiveNumbersIsPositive(int a, int b)
        {
            var result = _adder.Divide(a, b);
            Assert.True(result >= 0);
        }

        [Fact]
        public void DivideByZeroException()
        {
            Assert.Throws<ArgumentException>(() => _adder.Divide(10, 0));
        }
    }
}