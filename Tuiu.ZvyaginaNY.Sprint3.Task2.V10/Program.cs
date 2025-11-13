using System;
using Tuyu.ZvyaginaNY.Sprint3.Task2.V10.Lib;

namespace Tuyu.ZvyaginaNY.Sprint3.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int value = 1;  
            int startValue = 1;
            int stopValue = 13;

            double result = ds.GetMultiplySeries(value, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Переменная t: {value}");
            Console.WriteLine($" Старт шага: {startValue}");
            Console.WriteLine($" Конец шага: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Произведение ряда: {result}");
            Console.ReadKey();
        }
    }
}