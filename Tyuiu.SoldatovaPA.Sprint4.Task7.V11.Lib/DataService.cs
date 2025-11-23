using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyutu.SoldatovaPA.Sprint4.Task7.V11.Lib
{
    public class DataService : ISprint4Task7V11
    {
        public int Calculate(int n, int m, string value)
        {
            // Создаем матрицу n x m из строки
            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (index < value.Length)
                    {
                        matrix[i, j] = int.Parse(value[index].ToString());
                        index++;
                    }
                }
            }

            // Подсчитываем количество нечетных чисел
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0) // проверка на нечетность
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}