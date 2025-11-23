using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.SoldatovaPA.Sprint4.Task6.V30.Lib;

namespace Tyutu.SoldatovaPA.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            string[] result = ds.Calculate(array);

            // Ожидаемый результат: элементы с длиной больше 5 символов
            string[] expected = new string[] { "Береза", "Сосна", "Осина" };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWithAllShortStrings()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Дуб", "Клён", "Ель", "Ясень" };

            string[] result = ds.Calculate(array);

            // Ожидаемый результат: пустой массив (все строки длиной <= 5)
            string[] expected = new string[] { };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWithAllLongStrings()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Береза", "Сосна", "Осина", "Ельник" };

            string[] result = ds.Calculate(array);

            // Ожидаемый результат: все элементы (все строки длиной > 5)
            string[] expected = new string[] { "Береза", "Сосна", "Осина", "Ельник" };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWithEmptyArray()
        {
            DataService ds = new DataService();

            string[] array = new string[] { };

            string[] result = ds.Calculate(array);

            // Ожидаемый результат: пустой массив
            string[] expected = new string[] { };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWithMixedStrings()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Яблоня", "Дуб", "Вишня", "Клён", "Малина" };

            string[] result = ds.Calculate(array);

            // Ожидаемый результат: строки длиной больше 5 символов
            string[] expected = new string[] { "Яблоня", "Вишня", "Малина" };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}