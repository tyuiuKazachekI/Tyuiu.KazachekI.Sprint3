using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task0.V25.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.69;
            Assert.AreEqual(wait, res, 0.01);
        }

        [TestMethod]
        public void ValidGetSumSeriesFirstFewTerms()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 3;
            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.69;
            Assert.AreEqual(wait, res, 0.01);
        }
    }
}