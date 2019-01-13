using System.Collections.Generic;
using System.Linq;

namespace BookingQuest
{
    public static class Anagram
    {

        public static List<string> chechAnagrams(List<string> x)
        {
            List<List<string>> outputs = new List<List<string>>();
            List<string> input = new List<string>();
            input = x.OrderBy(v => v).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                List<string>lineres =new List<string>();
                for (int j = 0; j < input.Count; j++)
                {
                    if (anagramcheck(input[i],input[j]))
                    {
                        lineres.Add(input[j]);
                    }
                }
                if (lineres.Count>0)
                {
                    outputs.Add(lineres);
                }
            }
            List<string> finalres = new List<string>();
            foreach (var item in outputs)
            {
                string aa = string.Join(",", item.OrderBy(c => c).ToList());
                finalres.Add(aa);
            }

            return finalres.Distinct().ToList();
        }

        private static bool anagramcheck(string aline, string bline)
        {
            string aa = string.Join("", aline.Replace(" ", "").ToList().Distinct().OrderBy(x => x).ToList());
            string bb = string.Join("", bline.Replace(" ", "").ToList().Distinct().OrderBy(x => x).ToList());

            if (aa == bb)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}