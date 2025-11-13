using System;
using Tuiu.ZvyaginaNY.Sprint3.Task7.V30.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Начало диапазона: {startValue}");
            Console.WriteLine($" Конец диапазона: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");

            double[] res = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < res.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}  |", x, res[i]);
            }

            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}