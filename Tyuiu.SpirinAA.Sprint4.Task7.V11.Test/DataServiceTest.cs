using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint4.Task7.V11.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];
            string str = "56789012";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
