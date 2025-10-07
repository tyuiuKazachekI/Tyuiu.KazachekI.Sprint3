using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task7.V28.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Проверяем корректность массива
            Assert.AreEqual(11, res.Length); // от -5 до 5 включительно = 11 элементов
            Assert.IsFalse(double.IsNaN(res[0]));
            Assert.IsFalse(double.IsInfinity(res[0]));
        }

        [TestMethod]
        public void ValidGetMassFunctionDivisionByZero()
        {
            DataService ds = new DataService();
            int startValue = -3;
            int stopValue = -2;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            // При x = -2.5 должно быть деление на ноль → значение 0
            // Диапазон [-3, -2] содержит x = -3, -2, -2.5 нет в целых числах
            // Но проверим что нет ошибок
            Assert.AreEqual(2, res.Length);
        }

        [TestMethod]
        public void ValidGetMassFunctionSingleValue()
        {
            DataService ds = new DataService();
            int startValue = 0;
            int stopValue = 0;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            // x = 0: cos(0) + sin(0)/(0+2.5) + 0 = 1 + 0 + 0 = 1
            double expected = 1.0;
            double expectedRounded = Math.Round(expected, 2);

            Assert.AreEqual(expectedRounded, res[0]);
        }

        [TestMethod]
        public void ValidGetMassFunctionCalculation()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 1;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            // x = 1: cos(2) + sin(1)/(1+2.5) + 2*1
            double cos2 = Math.Cos(2);
            double sin1 = Math.Sin(1);
            double fraction = sin1 / 3.5;
            double expected = cos2 + fraction + 2;
            double expectedRounded = Math.Round(expected, 2);

            Assert.AreEqual(expectedRounded, res[0]);
        }

        [TestMethod]
        public void ValidGetMassFunctionNegativeValue()
        {
            DataService ds = new DataService();
            int startValue = -1;
            int stopValue = -1;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            // x = -1: cos(-2) + sin(-1)/(-1+2.5) + 2*(-1)
            double cosMinus2 = Math.Cos(-2);
            double sinMinus1 = Math.Sin(-1);
            double fraction = sinMinus1 / 1.5;
            double expected = cosMinus2 + fraction - 2;
            double expectedRounded = Math.Round(expected, 2);

            Assert.AreEqual(expectedRounded, res[0]);
        }
    }
}