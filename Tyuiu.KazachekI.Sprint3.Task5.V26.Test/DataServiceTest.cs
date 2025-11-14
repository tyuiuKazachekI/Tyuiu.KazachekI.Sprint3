using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task5.V26.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSimpleCalculation()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 1;
            int stopValue2 = 1;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double expected = 2.841;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}