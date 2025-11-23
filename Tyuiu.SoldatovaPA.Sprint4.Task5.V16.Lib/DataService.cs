using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyutu.SoldatovaPA.Sprint4.Task5.V16.Lib
{
    public class DataService : ISprint4Task5V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию массива
            int[,] result = (int[,])matrix.Clone();

            // Заменяем положительные элементы на 1
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (result[i, j] > 0) // проверка на положительность
                    {
                        result[i, j] = 1;
                    }
                }
            }

            return result;
        }
    }
}