using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShunanovKE.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            double max = -100000, min = 10000000;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double elem;
                while ((line = reader.ReadLine()) != null)
                {
                    elem = Convert.ToDouble(line);
                    if ((elem > 0 && elem < 10) || (elem < 0 && elem > -10))
                    {
                        max = Math.Max(elem, max);
                        min = Math.Min(elem, min);
                    }
                }
            }
            return Math.Round(max - min,3);
        }
    }
}
