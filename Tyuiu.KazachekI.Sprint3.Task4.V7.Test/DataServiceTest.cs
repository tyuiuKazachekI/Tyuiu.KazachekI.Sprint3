using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task4.V7.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSimpleCalculation()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;
            double result = ds.Calculate(startValue, stopValue);

            double expected = 3.351;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}