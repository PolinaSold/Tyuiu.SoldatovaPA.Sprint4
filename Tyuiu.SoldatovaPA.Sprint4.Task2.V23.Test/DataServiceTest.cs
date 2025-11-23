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

            int[] array = { 5, 5, 4, 3, 3, 3, 3, 7, 4, 6, 3, 6, 3, 6, 5 };

            int result = ds.Calculate(array);
            // ЧЕТНЫЕ элементы: 4, 4, 6, 6, 6
            // Сумма: 4 + 4 + 6 + 6 + 6 = 26

            Assert.AreEqual(26, result);
        }
    }
}
