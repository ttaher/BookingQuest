using System.Collections.Generic;

namespace BookingQuest
{
    public static class Polygon
    {
        public static string countMain(List<string> Maindata)
        {
            int sq = 0, rec = 0, pol = 0;
            for (int i = 0; i < Maindata.Count; i++)
            {
                count(Maindata[i], ref sq, ref rec, ref pol);
            }
            int x = 0;
            string Res = sq + " " + rec + " " + pol;
            return Res;
        }
        public static int count(string data, ref int sq, ref int rec, ref int pol)
        {

            string[] splitter = data.Split(' ');
            int[] sides = new int[splitter.Length];
            for (int j = 0; j < splitter.Length; j++)
            {
                sides[j] = int.Parse(splitter[j]);
                if (sides[j]<0 || sides[j]<-2000 || sides[j]>2000)
                {
                    return 0;
                }
            }
            if (IsSquare(sides))
                sq++;
            if (IsRectangle(sides))
                rec++;
            if (IsPolygon(sides))
                pol++;
            return 1;
          
        }

        private static bool IsSquare(int[] sides)
        {
            if (sides[0] == sides[1] && sides[1] == sides[2] && sides[2] == sides[3])
                return true;
            else return false;
        }
        private static bool IsRectangle(int[] sides)
        {
            if (sides[0] == sides[1] && sides[0] == sides[2] && sides[0] == sides[3] &&
             sides[2] == sides[3] && sides[1] == sides[2] && sides[1] == sides[3])
                return true;

            else if (sides[0] == sides[1] && sides[2] == sides[3])
                return true;

            else if (sides[0] == sides[1] && sides[2] == sides[1])
                return true;

            else if (sides[0] == sides[2] && sides[3] == sides[1])
                return true;

            else
                return false;
        }
        private static bool IsPolygon(int[] sides)
        {

            if (sides[0] > 0 && sides[0] <= 2000 && sides[0] == sides[2] && sides[1] <= 2000 && sides[1] > 0
                    && sides[1] == sides[3])
                return true;
            else return false;
        }
    }
}
