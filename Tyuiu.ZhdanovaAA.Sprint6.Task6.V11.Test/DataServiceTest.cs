using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ZhdanovaAA.Sprint6.Task6.V11.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V11.txt";
            string res = new DataService().CollectTextFromFile(path);
            Assert.AreEqual(res, "dwCKLDzrngpZmJ JmSRt gRwqYNbPcwgQilXS HjOGYcyzHD CmqxgaKlPLMCQBJC");
        }
    }
}
