using Xunit.Metadata.Management;

namespace Xunit.Metadata.Sample.Management
{
    public class AdderSubtractTests
    {
        public AdderSubtractTests()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Theory]
        [Bug]
        [Epic]
        [Feature]
        [Improvement]
        [Issue]
        [Story]
        [InlineData(4, 2, 2)]
        [InlineData(12, 10, 2)]
        public void SummationOfPositiveNumbers(int expected, int a, int b)
        {
            var result = _adder.Add(a, b);
            Assert.True(result > 0);
        }

        [Theory]
        [Bug("ABC")]
        [Epic("ABC")]
        [Feature("ABC")]
        [Improvement("ABC")]
        [Issue("ABC")]
        [Story("ABC")]
        [InlineData(-4, -2, -2)]
        [InlineData(-12, -10, -2)]
        public void SummationONegativeNumbers(int expected, int a, int b)
        {
            var result = _adder.Add(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [Bug("ABC", 123)]
        [Epic("ABC", 123)]
        [Feature("ABC", 123)]
        [Improvement("ABC", 123)]
        [Issue("ABC", 123)]
        [Story("ABC", 123)]
        [InlineData(0, -2, 2)]
        [InlineData(8, 10, -2)]
        public void SummationOfOppositeNumbers(int expected, int a, int b)
        {
            var result = _adder.Add(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        [Bug("ABC", 123)]
        [Epic("ABC", 123)]
        [Feature("ABC", 123)]
        [Improvement("ABC", 123)]
        [Issue("ABC", 123)]
        [Story("ABC", 123)]
        public void SumNegativeValues()
        {
            const int value = -5;
            var result = _adder.Add(value, -value);
            Assert.Equal(0, result);
        }

        [Fact]
        [Bug]
        [Epic]
        [Feature]
        [Improvement]
        [Issue]
        [Story]
        public void SumPositiveValues()
        {
            const int value = 10;
            var result = _adder.Add(value, -value);
            Assert.Equal(0, result);
        }

        [Fact]
        [Bug("ABC")]
        [Epic("ABC")]
        [Feature("ABC")]
        [Improvement("ABC")]
        [Issue("ABC")]
        [Story("ABC")]
        public void SumZeroValues()
        {
            const int value = 0;
            var result = _adder.Add(value, -value);
            Assert.Equal(0, result);
        }
    }
}