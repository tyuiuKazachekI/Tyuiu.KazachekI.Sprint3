using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task7.V28.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculation()
        {
            DataService ds = new DataService();

            int startValue = 0;
            int stopValue = 0;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            double expected = 1.0;

            Assert.AreEqual(expected, result[0]);
        }
    }
}