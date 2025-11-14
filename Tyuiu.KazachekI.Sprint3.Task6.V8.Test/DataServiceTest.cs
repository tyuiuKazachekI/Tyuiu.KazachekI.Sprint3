using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task6.V8.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSimpleCalculation()
        {
            DataService ds = new DataService();

            int startValue = 18;
            int stopValue = 18;
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            int expected = 18;

            Assert.AreEqual(expected, result);
        }
    }
}