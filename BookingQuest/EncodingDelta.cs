namespace BookingQuest
{
    public static class EncodingDelta
    {
        public static string DeltaEncodingMethod(string pattern)
        {
            string[] splitter = pattern.Split(' ');
            int[] x = new int[splitter.Length];
            for (int i = 0; i < splitter.Length; i++)
            {
                x[i] = int.Parse(splitter[i]);
            }
            string output = x[0] + " ";
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] - x[i - 1] > 127 || x[i] - x[i - 1] < -127)
                {
                    output += "-128 ";
                }
                output += (x[i] - x[i - 1] + " ");

            }
            return output;
        }
    }
}
