using System;
using Tuyu.ZvyaginaNY.Sprint3.Task2.V10.Lib;

namespace Tuyu.ZvyaginaNY.Sprint3.Task2.V10
{
    class Program  
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Звягина Н. Ю. | ИСПБ-25-1";

           
            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Звягина Н. Ю. | ИСПБ-25-1                                    *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при t=1                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*     13                                                                  *");
            Console.WriteLine("* p = ∏ (t^k + 1/(k+1))                                                   *");
            Console.WriteLine("*    k=1                                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");

            
            int value = 1;    
            int startValue = 1; 
            int stopValue = 13; 

            Console.WriteLine($" Значение t = {value}");
            Console.WriteLine($" Старт шага = {startValue}");
            Console.WriteLine($" Конец шага = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            
            DataService ds = new DataService();
            double result = ds.GetMultiplySeries(value, startValue, stopValue);

           
            Console.WriteLine($" Произведение ряда = {result}");

            Console.WriteLine();
            Console.WriteLine("***************");
            Console.WriteLine("* ДЕТАЛИ ВЫЧИСЛЕНИЙ:                                                      *");
            Console.WriteLine("***************");

           
            ShowCalculationDetails(value, startValue, stopValue);

            Console.WriteLine();
            Console.ReadKey();
           
            static void ShowCalculationDetails(int value, int startValue, int stopValue)
            {
                double product = 1.0;
                int k = startValue;

                Console.WriteLine(" k  | t^k  | 1/(k+1) | Член ряда | Произведение");
                Console.WriteLine("----|------|---------|-----------|-------------");

                do
                {
                    double tPower = Math.Pow(value, k);
                    double fraction = 1.0 / (k + 1);
                    double term = tPower + fraction;
                    double oldProduct = product;
                    product *= term;

                    Console.WriteLine($" {k,2} | {tPower,4:F1} | {fraction,7:F4} | {term,9:F4} | {product,11:F4}");

                    k++;
                }
                while (k <= stopValue);
            }
        }
    }
}