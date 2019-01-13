using System.Collections.Generic;
using Xunit;

namespace BookingQuest.Test
{
    public class ServiceCapacityTest
    {
        [Fact]
        public void ServiceCapacityTest0()
        {
            int CurrCustomerServer = 1;
            List<List<int>> PairsOfTimeStamp = new List<List<int>>();
            PairsOfTimeStamp.Add(new List<int>() { 1481122000, 1481122020 });
            PairsOfTimeStamp.Add(new List<int>() { 1481122000, 1481122040 });
            PairsOfTimeStamp.Add(new List<int>() { 1481122030, 1481122035 });

            int Actual = ServiceCapacity.CalculateServiceCapacity(CurrCustomerServer,  PairsOfTimeStamp);
            Assert.Equal(1, Actual);
        }
        [Fact]
        public void ServiceCapacityTest1()
        {
            int CurrCustomerServer = 1;
            List<List<int>> PairsOfTimeStamp = new List<List<int>>();
            PairsOfTimeStamp.Add(new List<int>() { 1481122000, 1481122020 });
            PairsOfTimeStamp.Add(new List<int>() { 1481122000, 1481122040 });
            PairsOfTimeStamp.Add(new List<int>() { 1481122030, 1481122035 });
            PairsOfTimeStamp.Add(new List<int>() { 1481122035, 1481122040 });

            int Actual = ServiceCapacity.CalculateServiceCapacity(CurrCustomerServer, PairsOfTimeStamp);
            Assert.Equal(2, Actual);
        }

    }
}
