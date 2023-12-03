using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint6.Task2.V28.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -1, end = 0;
            double[] res = ds.GetMassFunction(start, end);
            double[] wait = { 3.87, 2.00 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}