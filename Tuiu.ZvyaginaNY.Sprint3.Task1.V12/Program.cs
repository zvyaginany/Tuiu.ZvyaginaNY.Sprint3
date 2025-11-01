using System;
using Tuiu.ZvyaginaNY.Sprint3.Task1.V12.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Звягина Н.Ю. | ИСПБ 25-1";

            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Звягина Н.Ю. | ИСПБ 25-1                                     *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле, при n=5                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine($"Значение n = {value}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine($"Сумма ряда S = {result}");

            Console.WriteLine();
            Console.WriteLine("***************");
            Console.WriteLine("* ВЫПОЛНЕНИЕ ЗАВЕРШЕНО                                                     *");
            Console.WriteLine("***************");
            Console.ReadKey();
        }
    }
}