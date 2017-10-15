using Xunit;

namespace XUnit.Metadata
{

    public class Class1
    {
        [Fact]
        public void AddTwo()
        {
            Assert.Equal(5, 2 + 2);
        }
    }
}
