using System;
using Xunit.Metadata.Sample.Common;
using XUnit.Metadata.Management;

namespace Xunit.Metadata.Sample.Bug
{
    public class BugOnMethod
    {
        public BugOnMethod()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Fact]
        [Bug]
        public void ExceptionWhenDivideByZero()
        {
            var value = 10;
            Assert.Throws<ArgumentException>(() => _adder.Divide(value, 0));
        }
    }
}