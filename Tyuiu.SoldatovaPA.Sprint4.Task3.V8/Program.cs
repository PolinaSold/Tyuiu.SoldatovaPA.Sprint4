using System;
using Tyutu.SoldatovaPA.Sprint4.Task3.V8.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("**************************************************************************");

            int[,] array = new int[5, 5] {
                {4, 8, 3, 4, 8},
                {5, 3, 5, 7, 8},
                {3, 7, 2, 7, 7},
                {5, 2, 4, 6, 4},
                {4, 4, 6, 7, 2}
            };

            Console.WriteLine("* Массив 5x5:                                                          *");

            // Выводим массив
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
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("**************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine($"* Минимальный элемент в четвертом столбце: {result}");

            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}
