using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task7.V22.Lib
{
    public class DataService : ISprint6Task7V22
    {
        public int[,] GetMatrix(string path)
        {
            int[,] tmp;
            string text;
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }
            string[] lines = text.Replace("\r", "").Split('\n');
            tmp = new int[lines[0].Split(';').Length, lines.Length-1];
            for (int i = 0; i < lines.Length-1; i++)
            {
                string[] txt = lines[i].Split(';');
                for (int j = 0; j< lines[0].Split(';').Length; j++)
                {
                    if (j==5)
                    {
                        if (Convert.ToInt32(txt[j]) > 0 && Convert.ToInt32(txt[j])%2==0)
                        {
                            tmp[i, j] = 111;
                            continue;
                        }
                    }
                    tmp[i, j] = Convert.ToInt32(txt[j]);
                }
            }
            return tmp;

        }
    }
}
