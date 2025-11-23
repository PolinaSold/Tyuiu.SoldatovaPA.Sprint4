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

            // Создаем массив из 10 элементов с ФИКСИРОВАННЫМИ значениями
            int[] nums = { 4, 5, 6, 7, 8, 9, 4, 6, 8, 5 };

            Console.WriteLine("* Массив из 10 элементов:                                               *");

            // Выводим массив
            Console.Write("* Массив: [");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if (i < nums.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("]");

            // Выводим нечетные элементы для проверки
            Console.Write("* Нечетные элементы: [");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.Write(nums[i]);
                    if (i < nums.Length - 1) Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("**************************************************************************");

            // Создаем экземпляр сервиса и вычисляем результат
            DataService ds = new DataService();
            int result = ds.Calculate(nums);

            // Выводим результат
            Console.WriteLine($"* Сумма нечетных элементов массива: {result}");

            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}

