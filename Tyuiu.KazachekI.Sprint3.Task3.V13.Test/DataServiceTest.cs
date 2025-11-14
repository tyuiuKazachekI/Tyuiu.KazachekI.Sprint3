using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task3.V13.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
 
       
            [TestMethod]
            public void CheckSimpleConversion()
            {
                DataService ds = new DataService();

                string input = "abc5def";
                int result = ds.ConvertStringToInt(input);

                int expected = 5;

                Assert.AreEqual(expected, result);
            }
        }
    }