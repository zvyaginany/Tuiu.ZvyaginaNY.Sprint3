using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tuyu.ZvyaginaNY.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1;
            int k = startValue;

            do
            {
                double term = Math.Pow(value, k) + 1.0 / (k + 1);
                product *= term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }
}