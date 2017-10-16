﻿using Xunit;
using XUnit.Metadata.Common;

namespace XUnit.Metadata.Test
{
    public class Class1
    {
        [Bug("AR-100")]
        [Fact]
        public void AddTwo()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}
