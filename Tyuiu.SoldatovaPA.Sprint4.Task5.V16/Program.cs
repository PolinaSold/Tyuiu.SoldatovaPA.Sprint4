using System;
using Tyutu.SoldatovaPA.Sprint4.Task5.V16.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task5.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("**************************************************************************");

            int[,] array = new int[5, 5];
            Random rand = new Random();

            Console.WriteLine("* Массив 5x5, заполненный случайными значениями от -6 до 3:             *");

            // Заполняем массив случайными числами
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-6, 4); // от -6 до 3 включительно
                }
            }

            // Выводим исходный массив
            Console.WriteLine("* Исходный массив:                                                      *");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j],3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ (положительные элементы заменены на 1):                     *");
            Console.WriteLine("**************************************************************************");

            DataService ds = new DataService();
            int[,] result = ds.Calculate(array);

            // Выводим результирующий массив
            for (int i = 0; i < 5; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{result[i, j],3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}
