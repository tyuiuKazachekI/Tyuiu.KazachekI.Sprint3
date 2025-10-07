using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint3.Task3.V13.Lib;

namespace Tyuiu.KazachekI.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "?sd!! 5gh. s!";
            int res = ds.ConvertStringToInt(value);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConvertStringToIntMultipleDigits()
        {
            DataService ds = new DataService();
            string value = "a1b2c3d4";
            int res = ds.ConvertStringToInt(value);
            int wait = 1234;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConvertStringToIntOnlyDigits()
        {
            DataService ds = new DataService();
            string value = "12345";
            int res = ds.ConvertStringToInt(value);
            int wait = 12345;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConvertStringToIntNoDigits()
        {
            DataService ds = new DataService();
            string value = "abc!@#$%";
            int res = ds.ConvertStringToInt(value);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConvertStringToIntEmptyString()
        {
            DataService ds = new DataService();
            string value = "";
            int res = ds.ConvertStringToInt(value);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConvertStringToIntWithSpaces()
        {
            DataService ds = new DataService();
            string value = " 1 2 3 ";
            int res = ds.ConvertStringToInt(value);
            int wait = 123;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConvertStringToIntZero()
        {
            DataService ds = new DataService();
            string value = "zero0zero";
            int res = ds.ConvertStringToInt(value);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}