using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tuiu.ZvyaginaNY.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 2;

                
                if (Math.Abs(denominator) < 1e-10)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = 5 * x + 2.5;
                    double fraction = numerator / denominator;
                    double result = fraction + 2 * x + 2;
                    valueArray[count] = Math.Round(result, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}