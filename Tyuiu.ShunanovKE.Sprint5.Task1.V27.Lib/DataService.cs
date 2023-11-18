﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShunanovKE.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;

            if (fileexists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for(int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) - 3 + x == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2, 2);
                }
                strY = Convert.ToString(y);

                if(x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
