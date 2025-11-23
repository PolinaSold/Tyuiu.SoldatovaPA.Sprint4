using System;
using Tyutu.SoldatovaPA.Sprint4.Task4.V30.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("**************************************************************************");

            int[,] array = new int[5, 5];

            Console.WriteLine("* Введите 25 целых чисел в диапазоне от 3 до 7 для массива 5x5:         *");

            // Ввод данных с клавиатуры
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"* Элемент [{i},{j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());

                    // Проверка диапазона
                    while (array[i, j] < 3 || array[i, j] > 7)
                    {
                        Console.WriteLine("* Ошибка! Число должно быть в диапазоне от 3 до 7.");
                        Console.Write($"* Элемент [{i},{j}]: ");
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:                                                      *");
            Console.WriteLine("**************************************************************************");

            // Выводим исходный массив
            for (int i = 0; i < 5; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j]);
                    if (j < 4) Console.Write(", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ (нечетные элементы заменены на 0):                          *");
            Console.WriteLine("**************************************************************************");

            DataService ds = new DataService();
            int[,] result = ds.Calculate(array);

            // Выводим результирующий массив
            for (int i = 0; i < 5; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(result[i, j]);
                    if (j < 4) Console.Write(", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}
