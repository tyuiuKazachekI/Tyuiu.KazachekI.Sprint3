using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task6.V8.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            // Проверяем корректность вычислений
            Assert.IsTrue(res > 0);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsSingleNumber()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            // Для числа 18 делители > 11: 18
            int wait = 18;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsTwoNumbers()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 19;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            // Для 18: делители > 11 = 18
            // Для 19: делители > 11 = 19 (простое число)
            int wait = 18 + 19;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsCalculation()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            // Вычисляем вручную:
            // 18: 18
            // 19: 19
            // 20: 20
            // 21: 21
            // 22: 22
            // 24: 12, 24
            // 25: 25
            // 26: 13, 26
            // 27: 27
            // 28: 14, 28
            int wait = 18 + 19 + 20 + 21 + 22 + (12 + 24) + 25 + (13 + 26) + 27 + (14 + 28);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsEmptyRange()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 11;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            // В диапазоне [10, 11] нет делителей > 11
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}