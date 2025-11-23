using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.SoldatovaPA.Sprint4.Task3.V8.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                {4, 8, 3, 4, 8},
                {5, 3, 5, 7, 8},
                {3, 7, 2, 7, 7},
                {5, 2, 4, 6, 4},
                {4, 4, 6, 7, 2}
            };

            int result = ds.Calculate(array);

            // Четвертый столбец (индекс 3): 4, 7, 7, 6, 7
            // Минимальный элемент: 4

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestWithDifferentArray()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                {2, 3, 4, 5, 6},
                {3, 4, 5, 2, 7},
                {4, 5, 6, 8, 8},
                {5, 6, 7, 3, 9},
                {6, 7, 8, 4, 2}
            };

            int result = ds.Calculate(array);

            // Четвертый столбец (индекс 3): 5, 2, 8, 3, 4
            // Минимальный элемент: 2

            Assert.AreEqual(2, result);
        }
    }
}