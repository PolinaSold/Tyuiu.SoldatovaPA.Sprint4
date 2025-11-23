using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.SoldatovaPA.Sprint4.Task1.V30.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };

            int result = ds.Calculate(array);
            int wait = 13824; // 6 * 8 * 6 * 6 * 8 = 13824

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void TestWithNoEvenNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 5, 7, 9, 7, 5, 7, 9, 7, 5, 7, 9, 7, 5, 7, 9 };

            int result = ds.Calculate(array);
            int wait = 0; // нет четных чисел

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void TestWithAllEvenNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 6, 8, 6, 8, 6, 8, 6, 8, 6, 8, 6, 8, 6, 8, 6 };

            int result = ds.Calculate(array);
            // 6 * 8 * 6 * 8 * 6 * 8 * 6 * 8 * 6 * 8 * 6 * 8 * 6 * 8 * 6
            // но в диапазоне 5-9 только 6 и 8 являются четными

            Assert.IsTrue(result > 0);
        }
    }
}