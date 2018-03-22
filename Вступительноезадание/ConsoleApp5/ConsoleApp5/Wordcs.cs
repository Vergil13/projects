using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Wordcs
    {

       public string word { get; set; }
       public int numberwords { get; set; }
        

        public Wordcs(string word, int numberwords)
        {
            this.word = word;
            this.numberwords = numberwords;
        }

        public void CountWords (string [] textprogram , List<Wordcs> listWords)
        {
            List<string> sortingArray = new List<string>();
            for (int i = 0; i < listWords.Count; i++)
            {
                for (int j = 0; j < textprogram.Length; j++)
                {
                    if (textprogram[j]== listWords[i].word)
                    {
                        listWords[i].numberwords++;
                    }
                }
            }
        }
    } 

}
