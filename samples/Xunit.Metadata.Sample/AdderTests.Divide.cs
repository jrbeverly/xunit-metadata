using System;

namespace Xunit.Metadata.Sample
{
    [Acceptance("ABC")]
    [Benchmark("ABC")]
    [DisasterRecovery("ABC")]
    [Failover("ABC")]
    [Functional("ABC")]
    [Integration("ABC")]
    [Performance("ABC")]
    [Regression("ABC")]
    [Reliability("ABC")]
    [Smoke("ABC")]
    [Soak("ABC")]
    [Spike("ABC")]
    [Stress("ABC")]
    [System("ABC")]
    [Unit("ABC")]
    public class AdderDivideBaseTests
    {
        public AdderDivideBaseTests()
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