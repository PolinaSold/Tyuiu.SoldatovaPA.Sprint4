using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyutu.SoldatovaPA.Sprint4.Task4.V30.Lib
{
    public class DataService : ISprint4Task4V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию массива
            int[,] result = (int[,])matrix.Clone();

            // Заменяем нечетные элементы на 0
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (result[i, j] % 2 != 0) // проверка на нечетность
                    {
                        result[i, j] = 0;
                    }
                }
            }

            return result;
        }
    }
}