using System.Collections.Generic;
using System.Linq;
namespace BookingQuest
{
    public static class ServiceCapacity
    {
        public static int CalculateServiceCapacity(int noOfCurrentAgents, List<List<int>> callsTimes)
        {
            int output = 0;
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < callsTimes.Count; i++)
            {
                for (int k = 0; k < callsTimes.Count; k++)
                {
                    if (callsTimes[i][0] > callsTimes[k][0] && callsTimes[i][1] < callsTimes[k][1])
                    {
                        list.Add(callsTimes[i]);
                    }
                }
            }
            if (list.Count>0)
            {
                output = list.Count*2 - noOfCurrentAgents;
            }
            return output;
        }
    }
    //public class Call
    //{
    //    public double Start;
    //    public double End;
    //}
}
