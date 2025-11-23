using System;
using tyuiu.cources.programming.interfaces.Sprint4;
using Tyuiu.SoldatovaPA.Sprint4.Task1.V30.Lib;

namespace Tyuiu.SoldatovaPA.Sprint4.Task1.V30.Lib
{
    public class DataService : ISprint4Task1V30
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0) // Чётные числа
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
