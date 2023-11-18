using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShunanovKE.Sprint5.Task3.V20.Lib;

namespace Tyuiu.ShunanovKE.Sprint5.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Дарья\source\repos\Tyuiu.ShunanovKE.Sprint5\Tyuiu.ShunanovKE.Sprint5.Task3.V20\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
