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
            string[] lines = text.Split('\n');
            tmp = new int[lines[0].Split(';').Length, lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] txt = lines[i].Split(';');
                for (int j = 0; j< lines[0].Split(';').Length; j++)
                {
                    if (j == 11)
                    {
                        if (Convert.ToInt32(txt[j]) > 0 && Convert.ToInt32(txt[j])%2==0)
                        {
                            tmp[j, i] = 111;
                        }
                        else
                        {
                            tmp[j, i] = Convert.ToInt32(txt[j]);
                        }
                    }
                }
            }
            return tmp;

        }
    }
}
