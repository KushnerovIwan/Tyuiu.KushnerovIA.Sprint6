using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KushnerovIA.Sprint6.Task6.V9.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ContextTest()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V9.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "cas";
            Assert.AreEqual(wait, res);
        }
    }
}
