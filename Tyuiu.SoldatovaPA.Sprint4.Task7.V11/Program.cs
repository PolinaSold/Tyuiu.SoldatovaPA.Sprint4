using System;
using Tyutu.SoldatovaPA.Sprint4.Task7.V11.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("**************************************************************************");

            int n = 4; // строки
            int m = 2; // столбцы
            string value = "56789012";

            Console.WriteLine("* Параметры:                                                            *");
            Console.WriteLine($"* Количество строк (n): {n}");
            Console.WriteLine($"* Количество столбцов (m): {m}");
            Console.WriteLine($"* Исходная строка: \"{value}\"");

            Console.WriteLine("* Матрица 4x2:                                                          *");

            DataService ds = new DataService();
            int result = ds.Calculate(n, m, value);

            // Выводим матрицу для наглядности
            int[,] matrix = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < m; j++)
                {
                    if (index < value.Length)
                    {
                        matrix[i, j] = int.Parse(value[index].ToString());
                        Console.Write($"{matrix[i, j]} ");
                        index++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Количество нечетных чисел в матрице: {result}");

            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}
