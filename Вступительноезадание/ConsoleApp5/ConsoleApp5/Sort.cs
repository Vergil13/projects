using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace ConsoleApp5
{


    class Sorting 
    {
      private  string path;

        
        public void ReadingPath()
        {

            while (true)
            {
                string pathVerification = Console.ReadLine();
                if (!File.Exists(pathVerification))
                {
                    Console.WriteLine("input error, please entered right path");
                }
                else
                {
                    path = pathVerification;
                    break;
                }
            }
        }
        public string[] CleanerTextProgram() //Возвращает текст программы разбитый на массив для его дальнейщей сортировки
        {
            string textProgram =File.ReadAllText(path);
            if (Regex.IsMatch(path, "^([\\/\\/]{2}.+)|^([\\/]{1}[\\*]{1}).+([\\*]{1}[\\/]{1}))"))
            {
                textProgram = Regex.Replace(textProgram, "^([\\/]{1}[\\*]{1}).+([\\*]{1}[\\/]{1})", "");
                textProgram = Regex.Replace(textProgram, "([\\/\\/].+)(\\n)", "");
            }
            string[] arraywords = Regex.Split(textProgram,"\\w", RegexOptions.IgnorePatternWhitespace);
            return arraywords;
        }
        
        
       
        
        public List<string> GetListKeyWords(string[] keywords, string[] textProgram)
        {
            List<string> keywordsmass = new List<string>();
            Array.Sort(textProgram);
            for (int i = 0; i < keywords.Length; i++)
            {   
                for (int g = 0; g < textProgram.Length; g++)
                {
                    if (textProgram[g] == keywords[i])
                    {
                        keywordsmass.Add(keywords[i]);

                    }
                   
                }
            }
            return keywordsmass;


        }
    }
}
