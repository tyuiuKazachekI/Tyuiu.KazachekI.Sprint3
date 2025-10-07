using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task4.V7.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            // Ожидается 1231.499
            double wait = 1231.499;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateRangeWithoutZero()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 3;
            double res = ds.Calculate(startValue, stopValue);

            // Вычисляем вручную для x=1,2,3 и округляем до 3 знаков
            double y1 = (1 / Math.Cos(1)) + 1.5;
            double y2 = (2 / Math.Cos(2)) + 1.5;
            double y3 = (3 / Math.Cos(3)) + 1.5;
            double expected = y1 * y2 * y3;
            double expectedRounded = Math.Round(expected, 3);

            Assert.AreEqual(expectedRounded, res);
        }
    }
}