using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tuiu.ZvyaginaNY.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum =0;
            int k = startValue;
            while (k <= stopValue)
            {
                double term = 1.0 / Math.Pow(k, value);
                term = Math.Pow(term, 2);
                sum += term;
                k++;
            }
            return Math.Round(sum, 3);
        } 
    }
}