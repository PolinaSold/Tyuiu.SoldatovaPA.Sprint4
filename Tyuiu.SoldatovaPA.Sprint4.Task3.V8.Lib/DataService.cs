using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyutu.SoldatovaPA.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int min = int.MaxValue;

            // Четвертый столбец (индекс 3, так как индексация с 0)
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 3] < min)
                {
                    min = array[i, 3];
                }
            }

            return min;
        }
    }
}
