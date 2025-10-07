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

            // Вычисляем вручную для проверки:
            // k=1: (1/0.75^1)³ = (1/0.75)³ = (1.3333)³ = 2.37037
            // k=2: (1/0.75^2)³ = (1/0.5625)³ = (1.7778)³ = 5.61866
            // k=3: (1/0.75^3)³ = (1/0.421875)³ = (2.37037)³ = 13.3214
            // k=4: (1/0.75^4)³ = (1/0.316406)³ = (3.16049)³ = 31.5692
            // k=5: (1/0.75^5)³ = (1/0.237305)³ = (4.21399)³ = 74.8253

            // Произведение: 2.37037 × 5.61866 × 13.3214 × 31.5692 × 74.8253 ≈ 83508.5
            double wait = 83508.5;
            Assert.AreEqual(wait, res, 0.1);
        }

  
    }
}