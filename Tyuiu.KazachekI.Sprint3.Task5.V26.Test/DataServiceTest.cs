using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task5.V26.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Ожидается 49146.884
            double wait = 49146.884;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesSmallRange()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 2;
            int startValue2 = 1;
            int stopValue2 = 2;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Вычисляем вручную для i=1,2 и k=1,2 и округляем до 3 знаков
            // i=1: (2^1 + sin(1)) + (2^2 + sin(2)) = (2 + 0.84147) + (4 + 0.90930) = 2.84147 + 4.90930 = 7.75077
            // i=2: (2^1 + sin(1)) + (2^2 + sin(2)) = (2 + 0.84147) + (4 + 0.90930) = 2.84147 + 4.90930 = 7.75077
            // Общая сумма: 7.75077 + 7.75077 = 15.50154 → 15.502
            double expected = 15.502;

            Assert.AreEqual(expected, res, 0.001);
        }
    }
}