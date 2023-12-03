using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint6.Task0.V28.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 169.89;
            Assert.AreEqual(wait, res);
        }
    }
}