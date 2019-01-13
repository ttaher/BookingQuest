using System;
using System.Collections.Generic;
using System.Text;

namespace BookingQuest
{
    public static class Triangles
    { 
        public static int TriangleTypeCalc(int a, int b, int c)
        {
            int result = 0;
            try
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    result = 0;
                    return result;
                }
                if (!((long)a + (long)b > (long)c && (long)b + (long)c > (long)a && (long)a + (long)c > (long)b))
                {
                    result = 0;
                    return result;
                }
                if (a == b && b == c)
                {
                    result =1;
                    return result;
                }
                if (a == b || a == c || b == c)
                {
                    result = 2;
                    return result;
                }
                if (a != b && b != c && c != a)
                {
                    result = 2;
                    return result;
                }
            }
            catch
            {
                throw;
            }
            return result;
        }
    }
}
