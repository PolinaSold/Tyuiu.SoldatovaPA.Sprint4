using System;
using Tyuiu.SoldatovaPA.Sprint4.Task0.V12.Lib;

namespace Tyuiu.SoldatovaPA.Sprint4.Task0.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Солдатова П. А. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Обработка структурных типов                                      *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #12                                                            *");
            Console.WriteLine("* Выполнила: Солдатова П. А. | ИСПБ-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать произведение *");
            Console.WriteLine("* четных элементов массива.                                              *");
            Console.WriteLine("* Массив: {4, 6, 2, 8, 4, 5, 6, 9, 8, 7}                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            Console.Write("Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");

            DataService ds = new DataService();
            int result = ds.GetMultEvenArrEl(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение четных элементов = {result}");
            Console.ReadKey();
        }
    }
}