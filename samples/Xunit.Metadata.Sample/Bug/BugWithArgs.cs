using System;
using Xunit.Metadata.Management;

namespace Xunit.Metadata.Sample.Bug
{
    public sealed class BugWithArgs
    {
        public BugWithArgs()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Fact]
        [Bug("AR-102")]
        public void DivideByNegative()
        {
            var value = 10;
            Assert.Equal(-value, _adder.Divide(value, -1));
        }

        [Fact]
        [Bug("AR-101")]
        public void ExceptionWhenDivideByZero()
        {
            var value = 10;
            Assert.Throws<ArgumentException>(() => _adder.Divide(value, 0));
        }
    }
}