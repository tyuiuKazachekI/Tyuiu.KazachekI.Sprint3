using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task2.V8.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetMultiplySeries(startValue, stopValue);

            // Проверяем корректность вычислений
            // Все множители положительные и меньше 1, произведение должно быть положительным и меньше 1
            Assert.IsTrue(res > 0);
            Assert.IsTrue(res < 1);
        }


    }
}