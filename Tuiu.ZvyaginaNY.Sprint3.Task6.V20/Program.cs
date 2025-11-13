using System;
using Tuiu.ZvyaginaNY.Sprint3.Task6.V20.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 20;
            int stopValue = 32;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Начало отрезка: {startValue}");
            Console.WriteLine($" Конец отрезка: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Количество делителей меньше 12: {result}");
            Console.ReadKey();
        }
    }
}