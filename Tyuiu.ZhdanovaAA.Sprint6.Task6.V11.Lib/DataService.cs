using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            List<string> res = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null && line != "")
                {
                    var temp = line.Split();
                    res.Add(temp[temp.Length-1]);
                }
            }
            return String.Join(" ", res);
        }
    }
}
