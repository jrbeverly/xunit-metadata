using System;
using Xunit.Metadata.Sample.Common;
using XUnit.Metadata.Management;

namespace Xunit.Metadata.Sample.Bug
{
    [Bug]
    public sealed class BugOnClass
    {
        public BugOnClass()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(1, 1, 0)]
        [InlineData(0, -2, 2)]
        public void AddSet(int expected, int a, int b)
        {
            Assert.Equal(4, _adder.Add(a, b));
        }

        [Fact]
        public void ExceptionWhenDivideByZero()
        {
            var value = 10;
            Assert.Throws<ArgumentException>(() => _adder.Divide(value, 0));
        }
    }
}