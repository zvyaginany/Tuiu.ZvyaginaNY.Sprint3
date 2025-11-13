using System;
using Tuiu.ZvyaginaNY.Sprint3.Task4.V27.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Старт шага: {startValue}");
            Console.WriteLine($" Конец шага: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Сумма значений функции: {result}");
            Console.ReadKey();
        }
    }
}