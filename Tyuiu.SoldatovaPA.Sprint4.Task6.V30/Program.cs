using System;
using Tyutu.SoldatovaPA.Sprint4.Task6.V30.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task6.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("**************************************************************************");

            string[] array = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            Console.WriteLine("* Исходный массив строк:                                                *");
            Console.Write("* [");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\"{array[i]}\"");
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("]");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("**************************************************************************");

            DataService ds = new DataService();
            string[] result = ds.Calculate(array);

            Console.WriteLine("* Элементы массива, длина которых больше 5 символов:                    *");
            if (result.Length > 0)
            {
                Console.Write("* [");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write($"\"{result[i]}\"");
                    if (i < result.Length - 1) Console.Write(", ");
                }
                Console.WriteLine("]");
            }
            else
            {
                Console.WriteLine("* Нет элементов длиной больше 5 символов                             *");
            }

            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}
