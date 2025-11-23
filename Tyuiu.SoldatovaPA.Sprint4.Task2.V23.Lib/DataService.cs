using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyutu.SoldatovaPA.Sprint4.Task2.V23.Lib
{
    public class DataService : ISprint4Task2V23
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0) // проверка на нечетность
                {
                    product *= num;
                    hasOdd = true;
                }
            }

            return hasOdd ? product : 0; // если нет нечетных элементов, возвращаем 0
        }
    }
}