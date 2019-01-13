using System.Collections.Generic;
using Xunit;

namespace BookingQuest.Test
{
    public class TrianglesTest
    {
        [Fact]
        public void TrianglesTest0()
        {
            var Actual = Triangles.TriangleTypeCalc(3,5,4);
            Assert.Equal(2, Actual);
        }
        [Fact]
        public void TrianglesTest1()
        {
            var Actual = Triangles.TriangleTypeCalc(3, 3, 3);
            Assert.Equal(1, Actual);
        }
        [Fact]
        public void TrianglesTest2()
        {
            var Actual = Triangles.TriangleTypeCalc(-3, -3, -3);
            Assert.Equal(0, Actual);
        }
    }
}
