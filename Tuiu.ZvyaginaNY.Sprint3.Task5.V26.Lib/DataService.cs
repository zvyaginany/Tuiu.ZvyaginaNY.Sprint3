using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tuiu.ZvyaginaNY.Sprint3.Task5.V26.Lib
{
    public class DataService : ISprint3Task5V26
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                double innerSum = 0;
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double term = Math.Pow(x, k) + Math.Sin(k);
                    innerSum += term;
                }
                totalSum += innerSum;
            }

            return Math.Round(totalSum, 3);
        }
    }
}