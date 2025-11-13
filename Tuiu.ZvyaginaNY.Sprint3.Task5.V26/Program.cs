using System;
using Tuiu.ZvyaginaNY.Sprint3.Task5.V26.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 13;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Переменная X: {x}");
            Console.WriteLine($" Старт шага суммы 1: {startValue1}");
            Console.WriteLine($" Конец шага суммы 1: {stopValue1}");
            Console.WriteLine($" Старт шага суммы 2: {startValue2}");
            Console.WriteLine($" Конец шага суммы 2: {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Сумма сумм ряда: {result}");
            Console.ReadKey();
        }
    }
}