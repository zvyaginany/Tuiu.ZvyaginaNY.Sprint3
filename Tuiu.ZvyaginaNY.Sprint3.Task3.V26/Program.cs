using Tuiu.ZvyaginaNY.Sprint3.Task3.V26.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task3.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "have a nice time";
            char item = 'e';

            int result = ds.GetCharCount(value, item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Строка: {value}");
            Console.WriteLine($" Искомый символ: {item}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Количество символов '{item}' в строке: {result}");
            Console.ReadKey();
        }
    }
}