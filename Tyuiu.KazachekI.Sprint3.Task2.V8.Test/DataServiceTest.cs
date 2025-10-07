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

            // Ожидается 0.001
            double wait = 0.001;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesCalculation()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetMultiplySeries(startValue, stopValue);

            // Проверяем вычисление вручную:
            // cos(5) ≈ 0.28366
            // cos(5) + 1 ≈ 1.28366
            // (cos(5) + 1)² ≈ 1.64778
            // 1/(cos(5) + 1)² ≈ 0.60688
            // (0.60688)^15 ≈ 0.00103

            double cos5 = Math.Cos(5);
            double denominator = cos5 + 1;
            double term = 1.0 / Math.Pow(denominator, 2);
            double expected = Math.Pow(term, 15); // Умножаем 15 раз = возводим в степень 15

            Assert.AreEqual(Math.Round(expected, 3), res);
        }
    }
}