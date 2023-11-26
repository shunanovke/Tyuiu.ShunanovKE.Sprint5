using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShunanovKE.Sprint5.Task6.V23.Lib;

namespace Tyuiu.ShunanovKE.Sprint5.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V23.txt";
            int res = ds.LoadFromDataFile(path);
            int wait = 7;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V23.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool res = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
