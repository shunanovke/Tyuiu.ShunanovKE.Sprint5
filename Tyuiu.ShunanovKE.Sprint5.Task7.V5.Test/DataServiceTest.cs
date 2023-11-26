using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShunanovKE.Sprint5.Task7.V5.Lib;

namespace Tyuiu.ShunanovKE.Sprint5.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Дарья\source\repos\Tyuiu.ShunanovKE.Sprint5\Tyuiu.ShunanovKE.Sprint5.Task7.V5\bin\Debug\OutPutFileTask7V5.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool res = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
