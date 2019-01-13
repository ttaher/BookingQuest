using System.Collections.Generic;
using Xunit;

namespace BookingQuest.Test
{
    public class HotelReviewsTest
    {

        [Fact]
        public void HotelReviewsTest0()
        {
            string keywords = "breakfast beach citycenter location metro view staff price";
            List<string> reviewList = new List<string>();
            reviewList.Add("This hotel has a nice view of the citycenter. The location is perfect." );
            reviewList.Add("The breakfast is ok. Regarding location, it is quite far from citycenter but price is cheap so ot worth.");
            reviewList.Add("Location is excellent , 5 minutes from citycenter. There is also a metro station very close to the hotel");
            reviewList.Add("They said I couldn't take my dog and there were other guests woth dogs! That is not fair");
            reviewList.Add("Very friendly staff and good cost-benefit ratio. Its location is a bit far from citycenter" );
            List<int> hotellist = new List<int>() { 1,2,1,1,2};

            List<int> Actual = HotelReviews.Checkhotels(keywords,hotellist,reviewList);
            Assert.Equal(2, Actual[0]);
            Assert.Equal(1, Actual[1]);
        }
    }
}
