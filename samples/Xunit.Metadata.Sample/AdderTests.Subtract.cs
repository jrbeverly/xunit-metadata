namespace Xunit.Metadata.Sample
{
    public class AdderSubtractBaseTests
    {
        public AdderSubtractBaseTests()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Acceptance]
        [Benchmark]
        [DisasterRecovery]
        [Failover]
        [Functional]
        [Integration]
        [Performance]
        [Regression]
        [Reliability]
        [Smoke]
        [Soak]
        [Spike]
        [Stress]
        [System]
        [Unit]
        [InlineData(4, 2, 2)]
        [InlineData(12, 10, 2)]
        public void SummationOfPositiveNumbers(int expected, int a, int b)
        {
            var result = _adder.Add(a, b);
            Assert.True(result > 0);
        }

        [Theory]
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
        [InlineData(-4, -2, -2)]
        [InlineData(-12, -10, -2)]
        public void SummationONegativeNumbers(int expected, int a, int b)
        {
            var result = _adder.Add(a, b);
            Assert.Equal(expected, result);
        }

        [Acceptance]
        [Benchmark]
        [DisasterRecovery]
        [Failover]
        [Functional]
        [Integration]
        [Performance]
        [Regression]
        [Reliability]
        [Smoke]
        [Soak]
        [Spike]
        [Stress]
        [System]
        [Unit]
        public void SumPositiveValues()
        {
            const int value = 10;
            var result = _adder.Add(value, -value);
            Assert.Equal(0, result);
        }

        [Fact]
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
        public void SumZeroValues()
        {
            const int value = 0;
            var result = _adder.Add(value, -value);
            Assert.Equal(0, result);
        }
    }
}