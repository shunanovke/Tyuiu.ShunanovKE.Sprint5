using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.ShunanovKE.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string outpath = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V5.txt";

            FileInfo fileinfo = new FileInfo(outpath);
            bool fileex = fileinfo.Exists;

            if (fileex)
            {
                File.Delete(outpath);
            }
            string latin = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM", line;
            using (StreamReader reader = new StreamReader(path))
            {
                line = reader.ReadLine();
            }
            string a;
            foreach (char i in latin)
            {
                a = Convert.ToString(i);
                line = line.Replace(a, String.Empty);
            }
            File.AppendAllText(outpath, line);
            return outpath;
        }
    }
}

