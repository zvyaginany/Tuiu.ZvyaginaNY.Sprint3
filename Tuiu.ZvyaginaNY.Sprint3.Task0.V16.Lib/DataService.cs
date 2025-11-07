using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tuiu.ZvyaginaNY.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;
            for (int k = startValue; k <= stopValue; k++)
            {
                double term = (double)value / k;
                product *= term * term * term; // Более точное вычисление куба
            }
            return Math.Round(product, 3);
        }
    }
}