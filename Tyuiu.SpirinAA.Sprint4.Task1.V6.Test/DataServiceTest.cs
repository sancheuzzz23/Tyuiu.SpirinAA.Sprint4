using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using Tyuiu.SpirinAA.Sprint4.Task1.V6.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };

            int res = ds.Calculate(array);
            int wait = 1024;

            Assert.AreEqual(wait, res);
        }
    }
}
