using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyutu.SoldatovaPA.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            // Используем класс Array для фильтрации элементов с длиной > 5
            string[] result = Array.FindAll(array, element => element.Length > 5);
            return result;
        }
    }
}