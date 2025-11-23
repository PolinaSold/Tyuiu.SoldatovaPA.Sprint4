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

            // Создаем массив из 10 элементов
            int[] nums = new int[10];
            Random rand = new Random();

            Console.WriteLine("* Массив из 10 элементов, заполненный случайными значениями от 4 до 9:  *");

            // Заполняем массив случайными числами
            for (int i = 0; i < 10; i++)
            {
                nums[i] = rand.Next(4, 10); // от 4 до 9 включительно
            }

            // Выводим сгенерированный массив
            Console.Write("* Сгенерированный массив: [");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if (i < nums.Length - 1) Console.Write(", ");
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
