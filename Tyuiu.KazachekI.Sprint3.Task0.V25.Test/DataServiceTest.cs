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


            double a1 = 4.0 / 26;
            double q = a1;
            double expected = a1 * (1 - Math.Pow(q, 14)) / (1 - q);

            Assert.AreEqual(expected, res, 0.0001);
        }


        
    }
}