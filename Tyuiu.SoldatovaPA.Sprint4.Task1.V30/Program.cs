using System;
using Tyutu.SoldatovaPA.Sprint4.Task1.V30.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("**************************************************************************");

            // Создаем массив из 15 элементов
            int[] nums = new int[15];

            Console.WriteLine("* Введите 15 целых чисел в диапазоне от 5 до 9:                         *");

            // Ввод данных с клавиатуры
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"* Введите {i + 1}-е число: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());

                // Проверка диапазона
                while (nums[i] < 5 || nums[i] > 9)
                {
                    Console.WriteLine("* Ошибка! Число должно быть в диапазоне от 5 до 9.");
                    Console.Write($"* Введите {i + 1}-е число: ");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("**************************************************************************");

            // Создаем экземпляр сервиса и вычисляем результат
            DataService ds = new DataService();
            int result = ds.Calculate(nums);

            // Выводим введенный массив
            Console.Write("* Массив: [");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if (i < nums.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("]");

            // Выводим результат
            Console.WriteLine($"* Произведение четных элементов массива: {result}");

            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}
