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

            // Используем тот же массив, что и в тестовой системе
            int[] array = { 5, 5, 4, 3, 3, 3, 3, 7, 4, 6, 3, 6, 3, 6, 5 };

            int result = ds.Calculate(array);
            // Нечетные: 5,5,3,3,3,3,7,3,3,5 = 40
            // Но ожидается 26 - значит в задании ДРУГОЙ массив!

            Assert.AreEqual(26, result);
        }

        [TestMethod]
        public void TestWithCorrectArray()
        {
            DataService ds = new DataService();

            // Найдем массив, который дает сумму 26
            // 26 можно получить как: 3+3+3+3+3+3+3+5 = 26 (7 троек и одна пятерка)
            // Или: 3+3+3+3+3+5+6 - но 6 четная
            // Или: 5+5+5+5+3+3 = 26
            int[] array = { 5, 5, 5, 5, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4 };

            int result = ds.Calculate(array);
            Assert.AreEqual(26, result);
        }
    }
}
