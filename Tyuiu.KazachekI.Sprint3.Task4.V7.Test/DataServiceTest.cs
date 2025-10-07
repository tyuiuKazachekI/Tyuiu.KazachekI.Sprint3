using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task4.V7.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            // Проверяем корректность вычислений
            // Цикл должен прерваться при x=0, поэтому перемножаются значения от -5 до -1
            Assert.IsFalse(double.IsNaN(res));
            Assert.IsFalse(double.IsInfinity(res));
        }

        [TestMethod]
        public void ValidCalculateRangeWithoutZero()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 3;
            double res = ds.Calculate(startValue, stopValue);

            // Вычисляем вручную для x=1,2,3
            double y1 = (1 / Math.Cos(1)) + 1.5;
            double y2 = (2 / Math.Cos(2)) + 1.5;
            double y3 = (3 / Math.Cos(3)) + 1.5;
            double expected = y1 * y2 * y3;
            double expectedRounded = Math.Round(expected, 5);

            Assert.AreEqual(expectedRounded, res);
        }

        [TestMethod]
        public void ValidCalculateBreakAtZero()
        {
            DataService ds = new DataService();
            int startValue = -2;
            int stopValue = 2;
            double res = ds.Calculate(startValue, stopValue);

            // Цикл должен прерваться при x=0, поэтому перемножаются только x=-2 и x=-1
            double y_minus2 = (-2 / Math.Cos(-2)) + 1.5;
            double y_minus1 = (-1 / Math.Cos(-1)) + 1.5;
            double expected = y_minus2 * y_minus1;
            double expectedRounded = Math.Round(expected, 5);

            Assert.AreEqual(expectedRounded, res);
        }

        [TestMethod]
        public void ValidCalculateOnlyNegative()
        {
            DataService ds = new DataService();
            int startValue = -3;
            int stopValue = -1;
            double res = ds.Calculate(startValue, stopValue);

            // Нет нуля в диапазоне, поэтому все значения перемножаются
            double y_minus3 = (-3 / Math.Cos(-3)) + 1.5;
            double y_minus2 = (-2 / Math.Cos(-2)) + 1.5;
            double y_minus1 = (-1 / Math.Cos(-1)) + 1.5;
            double expected = y_minus3 * y_minus2 * y_minus1;
            double expectedRounded = Math.Round(expected, 5);

            Assert.AreEqual(expectedRounded, res);
        }

        [TestMethod]
        public void ValidCalculateZeroAtStart()
        {
            DataService ds = new DataService();
            int startValue = 0;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            // Цикл начинается с x=0 и сразу прерывается
            double expected = 1.0; // product инициализирован как 1.0
            Assert.AreEqual(expected, res);
        }
    }
}