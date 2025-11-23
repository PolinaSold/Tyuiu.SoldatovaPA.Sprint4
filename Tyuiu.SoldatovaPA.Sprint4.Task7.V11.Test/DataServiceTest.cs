using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.SoldatovaPA.Sprint4.Task7.V11.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            string value = "56789012";

            int result = ds.Calculate(n, m, value);

            // Матрица 4x2: 
            // 5, 6
            // 7, 8  
            // 9, 0
            // 1, 2
            // Нечетные: 5, 7, 9, 1 = 4
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestWithAllOddNumbers()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            string value = "13579135";

            int result = ds.Calculate(n, m, value);

            // Все числа нечетные
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestWithAllEvenNumbers()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            string value = "24680246";

            int result = ds.Calculate(n, m, value);

            // Все числа четные
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestDifferentMatrixSize()
        {
            DataService ds = new DataService();

            int n = 2;
            int m = 4;
            string value = "12345678";

            int result = ds.Calculate(n, m, value);

            // Матрица 2x4:
            // 1, 2, 3, 4
            // 5, 6, 7, 8
            // Нечетные: 1, 3, 5, 7 = 4
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestWithShortString()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            string value = "12345";

            int result = ds.Calculate(n, m, value);

            // Матрица 3x3 (заполнены только 5 элементов):
            // 1, 2, 3
            // 4, 5, 0
            // 0, 0, 0
            // Нечетные: 1, 3, 5 = 3
            Assert.AreEqual(3, result);
        }
    }
}
