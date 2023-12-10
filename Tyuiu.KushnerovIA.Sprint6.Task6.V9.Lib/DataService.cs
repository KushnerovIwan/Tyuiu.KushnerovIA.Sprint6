using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.KushnerovIA.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {

        public string CollectTextFromFile(string path)
        {
            string[] content = File.ReadAllLines(path);
            string result = "";

            foreach (string line in content)
            {
                string[] words = line.Split(' ');

                // Проверяем, что в строке есть хотя бы одно слово
                if (words.Length > 0)
                {
                    // Берем последнеe слово и добавляем к результату
                    result += words[words.Length - 1];
                }
            }
            return result;
        }
    }
}



