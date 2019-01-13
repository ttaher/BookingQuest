using System.Collections.Generic;
using Xunit;

namespace BookingQuest.Test
{
    public class PolygonTest
    {
        private readonly List<string> LineList = new List<string>() { "36 30 36 30", "15 15 15 15", "46 96 90 100", "86 86 86 86", "100 200 100 200", "-100 200 -100 200" };
        [Fact]
        public void PolygonTest0()
        {
            var Actual = Polygon.countMain(LineList);
            Assert.Equal("2 4 4", Actual);
        }
    }
}
