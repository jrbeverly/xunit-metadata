using System;
using Xunit.Metadata.Management;

namespace Xunit.Metadata.Sample.Unit
{
    public class OnMethod
    {
        public OnMethod()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Theory]
        [Bug("OnMethod")]
        [InlineData(3, 1, 2)]
        public void Theory_SingleInline(int expected, int a, int b)
        {
            Assert.Equal(expected, _adder.Add(a, b));
        }


        [Theory]
        [Bug("OnMethod")]
        [InlineData(3, 1, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(0, 2, -2)]
        public void Theory_MultipleInline(int expected, int a, int b)
        {
            Assert.Equal(expected, _adder.Add(a, b));
        }

        [Fact]
        [Bug("OnMethod")]
        public void Fact_Single()
        {
            var value = 10;
            Assert.Throws<ArgumentException>(() => _adder.Divide(value, 0));
        }
    }
}