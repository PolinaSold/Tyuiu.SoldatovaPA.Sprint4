using System;
using tyuiu.cources.programming.interfaces.Sprint4;
using Tyuiu.SoldatovaPA.Sprint4.Task0.V12.Lib;

namespace Tyuiu.SoldatovaPA.Sprint4.Task0.V12.Lib
{
    public class DataService : ISprint4Task0V12
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0) // Проверка на чётность
                {
                    product *= num;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0;
        }
    }
}