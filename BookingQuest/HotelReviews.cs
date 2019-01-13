using System.Collections.Generic;
using System.Linq;

namespace BookingQuest
{
    public static class HotelReviews
    {
        public static List<int> Checkhotels(string keywords, List<int> hotel_ids, List<string> reviews)
        {
            List<List<int>> _temhotelRank = new List<List<int>>();

            List<List<int>> _hotelRank = new List<List<int>>();
            List<int> output = new List<int>();
            for (int i = 0; i < hotel_ids.Count; i++)
            {
                foreach (string word in keywords.Split(' '))
                {
                    string review = reviews[i].Replace(".", "").Replace(",", "").Trim();
                    if (review.IndexOf(word.Trim()) > -1)
                    {
                        _temhotelRank.Add(new List<int>() { i + 1, 1 });
                    }
                }
            }
            foreach (int item in hotel_ids.Distinct())
            {
                int Rankcount = _temhotelRank.Where(x => x[0] == item).Sum(x => x[1]);
                _hotelRank.Add(new List<int>() { item, Rankcount });
            }
            output = _hotelRank.OrderByDescending(o => o[1]).ToList().Select(x => x[0]).ToList();
            return output;
        }
    }
    public class ReviewDetail
    {
        public int hotelid;
        public string Review;
    }

    public class HotelRank
    {
        public int hotelid;
        public int RankCount;
    }
}
