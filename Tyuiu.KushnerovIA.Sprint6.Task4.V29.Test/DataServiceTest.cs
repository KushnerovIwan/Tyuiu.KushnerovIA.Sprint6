using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint6.Task4.V29.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task4.V29.Test
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
            int len = (stopValue - startValue) + 1;
            double[] wait = new double[len];
            wait[0] = -32.26;
            wait[1] = -27.50;
            wait[2] = -22.80;
            wait[3] = -17.95;
            wait[4] = -12.97;
            wait[5] = -9.00;
            wait[6] = -0.31;
            wait[7] = 3.77;
            wait[8] = 8.57;
            wait[9] = 13.42;
            wait[10] = 18.28;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);


        }
    }
}
