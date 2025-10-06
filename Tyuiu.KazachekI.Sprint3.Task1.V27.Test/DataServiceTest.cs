using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task1.V27.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            // Проверяем корректность вычислений
            // Произведение должно быть положительным числом
            Assert.IsTrue(res > 0);
            Assert.IsTrue(res < 1); // Все множители меньше 1, произведение должно быть меньше 1
        }


    }
}