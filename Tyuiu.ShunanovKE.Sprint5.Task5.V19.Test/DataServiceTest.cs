using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShunanovKE.Sprint5.Task5.V19.Lib;

namespace Tyuiu.ShunanovKE.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            Assert.AreEqual(true, fileex);
        }
    }
}
