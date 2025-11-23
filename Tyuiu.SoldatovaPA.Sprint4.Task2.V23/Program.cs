using System;
using Tyutu.SoldatovaPA.Sprint4.Task2.V23.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("**************************************************************************");

            // Массив из тестовой системы
            int[] nums = { 5, 5, 4, 3, 3, 3, 3, 7, 4, 6, 3, 6, 3, 6, 5 };

            Console.WriteLine("* Массив из 15 элементов:                                               *");

            // Выводим массив
            Console.Write("* Массив: [");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if (i < nums.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("]");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("**************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(nums);

            Console.WriteLine($"* Сумма ЧЕТНЫХ элементов массива: {result}");

            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}

