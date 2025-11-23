using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.SoldatovaPA.Sprint4.Task5.V16.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                {-3,  2, -5,  1, -2},
                {-6,  0, -1,  3, -4},
                { 2, -3,  1, -2,  0},
                {-1,  3, -4,  2, -5},
                { 0, -2,  1, -3,  2}
            };

            int[,] result = ds.Calculate(array);

            // Ожидаемый результат (положительные заменены на 1):
            int[,] expected = new int[5, 5] {
                {-3,  1, -5,  1, -2},
                {-6,  0, -1,  1, -4},
                { 1, -3,  1, -2,  0},
                {-1,  1, -4,  1, -5},
                { 0, -2,  1, -3,  1}
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
        public void TestWithNoPositiveNumbers()
        {
            DataService ds = new DataService();

            int[,] array = new int[3, 3] {
                {-3, -2, -5},
                {-6, -1, -4},
                {-2, -3, -1}
            };

            int[,] result = ds.Calculate(array);

            // Нет положительных элементов, поэтому массив не должен измениться
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(array[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestWithAllPositiveNumbers()
        {
            DataService ds = new DataService();

            int[,] array = new int[2, 2] {
                {1, 2},
                {3, 1}
            };

            int[,] result = ds.Calculate(array);

            // Все элементы положительные, поэтому должны стать 1
            int[,] expected = new int[2, 2] {
                {1, 1},
                {1, 1}
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestWithMixedNumbers()
        {
            DataService ds = new DataService();

            int[,] array = new int[2, 3] {
                {-2, 0, 3},
                {1, -1, 2}
            };

            int[,] result = ds.Calculate(array);

            int[,] expected = new int[2, 3] {
                {-2, 0, 1},
                {1, -1, 1}
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}
