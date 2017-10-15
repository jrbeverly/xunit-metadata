using Xunit;

namespace XUnit.Metadata.Test
{
    public class Class1
    {
        [Fact]
        public void AddTwo()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}
