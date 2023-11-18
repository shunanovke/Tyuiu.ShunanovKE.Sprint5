using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShunanovKE.Sprint5.Task0.V8.Lib;

namespace Tyuiu.ShunanovKE.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\Дарья\source\repos\Tyuiu.ShunanovKE.Sprint5\Tyuiu.ShunanovKE.Sprint5.Task0.V8\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
