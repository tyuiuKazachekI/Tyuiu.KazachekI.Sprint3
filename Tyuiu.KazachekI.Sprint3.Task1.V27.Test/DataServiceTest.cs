using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task1.V27.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSimpleMultiplication()
        {
            DataService ds = new DataService();

            double n = 0.75;
            int startValue = 1;
            int stopValue = 1;
            double result = ds.GetMultiplySeries(n, startValue, stopValue);

            double expected = 2.4;

            Assert.AreEqual(expected, result);
        }
    }
}