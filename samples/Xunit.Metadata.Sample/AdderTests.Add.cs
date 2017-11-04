namespace Xunit.Metadata.Sample
{
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
    public class AdderAddBaseTests
    {
        public AdderAddBaseTests()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Theory]
        [InlineData(2, 2)]
        [InlineData(10, 0)]
        public void GivenPositiveNumbersIsPositive(int a, int b)
        {
            var result = _adder.Add(a, b);
            Assert.True(result > 0);
        }

        [Fact]
        public void AddSameSum()
        {
            const int value = 10;
            var result = _adder.Add(value, -value);
            Assert.Equal(0, result);
        }
    }
}