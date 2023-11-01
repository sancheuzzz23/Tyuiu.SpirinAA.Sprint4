using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using Tyuiu.SpirinAA.Sprint4.Task2.V12.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            
            int[] array = { 4, 6, 4, 7, 8, 5, 4, 8, 5, 4, 5, 7, 6, 9 };

            int res = ds.Calculate(array);
            int wait = 38;

            Assert.AreEqual(wait, res);
        }
    }
}
