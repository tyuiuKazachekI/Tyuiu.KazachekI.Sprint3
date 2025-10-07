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
            Assert.AreEqual(wait, res, 0.001); // Допуск 0.001
        }

        [TestMethod]
        public void ValidGetMultiplySeriesFirstTerm()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 1;
            double res = ds.GetMultiplySeries(startValue, stopValue);

            // k=1: 1/(cos(1) + 1)²
            double cos1 = Math.Cos(1);
            double denominatorSquared = Math.Pow(cos1 + 1, 2);
            double expected = 1.0 / denominatorSquared;
            double expectedRounded = Math.Round(expected, 3);

            Assert.AreEqual(expectedRounded, res);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesFirstTwoTerms()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 2;
            double res = ds.GetMultiplySeries(startValue, stopValue);

            // k=1: 1/(cos(1) + 1)²
            double term1 = 1.0 / Math.Pow(Math.Cos(1) + 1, 2);
            // k=2: 1/(cos(2) + 1)²
            double term2 = 1.0 / Math.Pow(Math.Cos(2) + 1, 2);
            double expected = term1 * term2;
            double expectedRounded = Math.Round(expected, 3);

            Assert.AreEqual(expectedRounded, res);
        }
    }
}