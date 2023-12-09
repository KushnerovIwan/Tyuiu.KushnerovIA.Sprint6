using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint6.Task5.V9.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidShaitanMachin()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\kia45\source\repos\Tyuiu.KushnerovIA.Sprint6\Tyuiu.KushnerovIA.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { -13, -19, -9.82, 13, 11.49, -9.71, 3.36, 14.52, 16, 13.66, 4.13, -0.11, 19, -17.36, 11, 11.28, -12, -12.35 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}