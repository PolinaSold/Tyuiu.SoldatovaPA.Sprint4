using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyutu.SoldatovaPA.Sprint4.Task1.V30.Lib
{
    public class DataService : ISprint4Task1V30
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0) // проверка на четность
                {
                    product *= num;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0; // если нет четных элементов, возвращаем 0
        }
    }
}