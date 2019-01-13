using System.Collections.Generic;
using Xunit;

namespace BookingQuest.Test
{
    public class EncodingDeltaTest
    {
        string LineList = "25626 25757 24367 16 100 2 7277";
        string Expected = "25626 -128 131 -128 -1390 -128 -24351 84 -98 -128 7275";
        [Fact]
        public void EncodingTest0()
        {
            var Actual = EncodingDelta.DeltaEncodingMethod(LineList);
            Assert.Equal(Expected, Actual.Trim());
        }
    }
}
