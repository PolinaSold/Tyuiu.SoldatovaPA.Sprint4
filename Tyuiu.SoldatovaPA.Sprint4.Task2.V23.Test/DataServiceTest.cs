using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.SoldatovaPA.Sprint4.Task2.V23.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тестовый массив с нечетными числами: 5, 7, 9, 5
            int[] array = { 4, 5, 6, 7, 8, 9, 4, 6, 8, 5 };

            int result = ds.Calculate(array);
            int wait = 5 + 7 + 9 + 5; // Сумма всех нечетных элементов = 26

            Assert.AreEqual(26, result);
        }

        [TestMethod]
        public void TestWithNoOddNumbers()
        {
            DataService ds = new DataService();

            // Массив только с четными числами (4, 6, 8)
            int[] array = { 4, 6, 8, 4, 6, 8, 4, 6, 8, 4 };

            int result = ds.Calculate(array);
            int wait = 0; // нет нечетных чисел

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void TestWithAllOddNumbers()
        {
            DataService ds = new DataService();

            // Массив только с нечетными числами (5, 7, 9)
            int[] array = { 5, 7, 9, 5, 7, 9, 5, 7, 9, 5 };

            int result = ds.Calculate(array);
            int wait = 5 + 7 + 9 + 5 + 7 + 9 + 5 + 7 + 9 + 5;

            Assert.AreEqual(wait, result);
        }
    }
}
