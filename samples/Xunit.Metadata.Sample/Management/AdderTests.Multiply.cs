using Xunit.Metadata.Management;

namespace Xunit.Metadata.Sample.Management
{
    [Bug("ABC", 123)]
    [Epic("ABC", 123)]
    [Feature("ABC", 123)]
    [Improvement("ABC", 123)]
    [Issue("ABC", 123)]
    [Story("ABC", 123)]
    public class AdderMultiplyTests
    {
        public AdderMultiplyTests()
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