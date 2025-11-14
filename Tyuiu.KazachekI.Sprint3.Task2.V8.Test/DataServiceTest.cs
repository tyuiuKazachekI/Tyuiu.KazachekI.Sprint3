using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task2.V8.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSimpleMultiplication()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;
            double result = ds.GetMultiplySeries(startValue, stopValue);


            double expected = 0.607;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}