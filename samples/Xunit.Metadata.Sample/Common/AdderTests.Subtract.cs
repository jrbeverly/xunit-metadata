using Xunit.Metadata.Common;

namespace Xunit.Metadata.Sample.Common
{
    public class AdderSubtractTests
    {
        public AdderSubtractTests()
        {
            _adder = new Adder();
        }

        private readonly Adder _adder;

        [Database]
        [ExternalDependency]
        [FileSystem]
        [Online]
        [Security]
        [InlineData(4, 2, 2)]
        [InlineData(12, 10, 2)]
        public void SummationOfPositiveNumbers(int expected, int a, int b)
        {
            var result = _adder.Add(a, b);
            Assert.True(result > 0);
        }

        [Database("ABC")]
        [ExternalDependency("ABC")]
        [FileSystem("ABC")]
        [Online("ABC")]
        [Security("ABC")]
        [InlineData(-4, -2, -2)]
        [InlineData(-12, -10, -2)]
        public void SummationONegativeNumbers(int expected, int a, int b)
        {
            var result = _adder.Add(a, b);
            Assert.True(result > 0);
        }

        [Database]
        [ExternalDependency]
        [FileSystem]
        [Online]
        [Security]
        public void SumPositiveValues()
        {
            const int value = 10;
            var result = _adder.Add(value, -value);
            Assert.Equal(0, result);
        }

        [Fact]
        [Database("ABC")]
        [ExternalDependency("ABC")]
        [FileSystem("ABC")]
        [Online("ABC")]
        [Security("ABC")]
        public void SumZeroValues()
        {
            const int value = 0;
            var result = _adder.Add(value, -value);
            Assert.Equal(0, result);
        }
    }
}