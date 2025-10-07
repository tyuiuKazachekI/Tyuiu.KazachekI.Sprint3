using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task1.V27.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double n = 0.75;
            int startValue = 1;
            int stopValue = 5;
            double res = ds.GetMultiplySeries(n, startValue, stopValue);

            // Ожидается 419028.1
            double wait = 419028.1;
            Assert.AreEqual(wait, res);
        }


    }
}