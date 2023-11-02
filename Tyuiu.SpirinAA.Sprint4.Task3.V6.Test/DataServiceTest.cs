using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint4.Task3.V6.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 8, 8, 3, 4, 5 }, 
                                          { 8, 6, 6, 4, 6 }, 
                                          { 3, 6, 5, 3, 4 }, 
                                          { 5, 6, 3, 7, 5 }, 
                                          { 7, 8, 5, 6, 6 } };

            int res = ds.Calculate(mas2);
            int wait = 8;

            Assert.AreEqual(wait, res);
        }
    }
}
