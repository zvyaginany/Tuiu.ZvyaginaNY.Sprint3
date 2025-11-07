using System;
using Tuiu.ZvyaginaNY.Sprint3.Task0.V16.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task0.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");
            Console.WriteLine("Значение X: 5");
            Console.WriteLine("Старт шага: 1");
            Console.WriteLine("Конец шага: 6");

            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            double result = ds.GetMultiplySeries(5, 1, 6);
            Console.WriteLine("Произведение ряда = " + result);
            Console.ReadKey();
        }
    }
}