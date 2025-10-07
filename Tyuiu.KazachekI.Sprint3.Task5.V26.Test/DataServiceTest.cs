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

            // Проверяем корректность вычислений
            Assert.IsFalse(double.IsNaN(res));
            Assert.IsFalse(double.IsInfinity(res));
            Assert.IsTrue(res > 0); // Результат должен быть положительным
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

            // Вычисляем вручную для i=1,2 и k=1,2
            // i=1: (2^1 + sin(1)) + (2^2 + sin(2)) = (2 + 0.84147) + (4 + 0.90930) = 2.84147 + 4.90930 = 7.75077
            // i=2: (2^1 + sin(1)) + (2^2 + sin(2)) = (2 + 0.84147) + (4 + 0.90930) = 2.84147 + 4.90930 = 7.75077
            // Общая сумма: 7.75077 + 7.75077 = 15.50154
            double expected = 15.50154;
            double expectedRounded = Math.Round(expected, 5);

            Assert.AreEqual(expectedRounded, res);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesSingleIteration()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 1;
            int stopValue2 = 1;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // i=1, k=1: 2^1 + sin(1) = 2 + 0.84147 = 2.84147
            double expected = 2.84147;
            double expectedRounded = Math.Round(expected, 5);

            Assert.AreEqual(expectedRounded, res);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesDifferentX()
        {
            DataService ds = new DataService();
            int x = 3;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 1;
            int stopValue2 = 2;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // i=1: (3^1 + sin(1)) + (3^2 + sin(2)) = (3 + 0.84147) + (9 + 0.90930) = 3.84147 + 9.90930 = 13.75077
            double expected = 13.75077;
            double expectedRounded = Math.Round(expected, 5);

            Assert.AreEqual(expectedRounded, res);
        }
    }
}