using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task0.V25.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSimpleSum()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 1;
            double result = ds.GetSumSeries(value, startValue, stopValue);

            double expected = 0.67;

            Assert.AreEqual(expected, result, 0.01);
        }
    }
}