using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.SoldatovaPA.Sprint4.Task4.V30.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                {3, 4, 6, 6, 5},
                {6, 7, 6, 3, 5},
                {5, 3, 5, 7, 6},
                {6, 4, 7, 6, 6},
                {7, 4, 3, 4, 5}
            };

            int[,] result = ds.Calculate(array);

            // Ожидаемый результат (нечетные заменены на 0):
            int[,] expected = new int[5, 5] {
                {0, 4, 6, 6, 0},
                {6, 0, 6, 0, 0},
                {0, 0, 0, 0, 6},
                {6, 4, 0, 6, 6},
                {0, 4, 0, 4, 0}
            };

            // Проверяем все элементы
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j],
                        $"Ошибка в элементе [{i},{j}]");
                }
            }
        }

        [TestMethod]
        public void TestWithAllEvenNumbers()
        {
            DataService ds = new DataService();

            int[,] array = new int[3, 3] {
                {4, 6, 4},
                {6, 4, 6},
                {4, 6, 4}
            };

            int[,] result = ds.Calculate(array);

            // Все элементы четные, поэтому массив не должен измениться
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(array[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestWithAllOddNumbers()
        {
            DataService ds = new DataService();

            int[,] array = new int[2, 2] {
                {3, 5},
                {7, 3}
            };

            int[,] result = ds.Calculate(array);

            // Все элементы нечетные, поэтому должны стать 0
            int[,] expected = new int[2, 2] {
                {0, 0},
                {0, 0}
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}
