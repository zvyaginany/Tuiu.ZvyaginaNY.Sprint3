using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tuiu.ZvyaginaNY.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalCount = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0 && d < 12)
                    {
                        totalCount++;
                    }
                }
            }

            return totalCount;
        }
    }
}