using System;
using Xunit.Metadata.Management;

namespace Xunit.Metadata.Sample.Smoke
{
    public class OnMethod
    {
        public OnMethod()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Theory]
        [Smoke]
        [InlineData(3, 1, 2)]
        public void Theory_SingleInline(int expected, int a, int b)
        {
            Assert.Equal(expected, _adder.Add(a, b));
        }


        [Theory]
        [Smoke]
        [InlineData(3, 1, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(0, 2, -2)]
        public void Theory_MultipleInline(int expected, int a, int b)
        {
            Assert.Equal(expected, _adder.Add(a, b));
        }

        [Fact]
        [Smoke]
        public void Fact_Single()
        {
            var value = 10;
            Assert.Throws<ArgumentException>(() => _adder.Divide(value, 0));
        }

        [Theory]
        [Smoke("OnMethod")]
        [InlineData(3, 1, 2)]
        public void TheoryWithArg_SingleInline(int expected, int a, int b)
        {
            Assert.Equal(expected, _adder.Add(a, b));
        }


        [Theory]
        [Smoke("OnMethod")]
        [InlineData(3, 1, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(0, 2, -2)]
        public void TheoryWithArg_MultipleInline(int expected, int a, int b)
        {
            Assert.Equal(expected, _adder.Add(a, b));
        }

        [Fact]
        [Smoke("OnMethod")]
        public void FactWithArg_Single()
        {
            var value = 10;
            Assert.Throws<ArgumentException>(() => _adder.Divide(value, 0));
        }
    }
}