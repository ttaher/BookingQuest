using System;
using System.Collections.Generic;
using System.Text;

namespace BookingQuest
{
    class Program
    {
        public static List<string> LineList = new List<string>();

        static void Main(string[] args)
        {
            callAnagram();
        }
        private static string Getline()
        {
            string line = Console.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                LineList.Add(line);
            }
            return line;
        }
        public static void callAnagram()
        {

            Getline();
            while (!string.IsNullOrEmpty(Getline()))
            {
                Getline();
            }
            List<string> input = new List<string>() { "pear", "amleth", "hamlet", "dorimtory", "dirty room", "listen", "silent", "tinsel" };
            List<string> collection = Anagram.chechAnagrams(LineList);

            foreach (var item in collection)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}
