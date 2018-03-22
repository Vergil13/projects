using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SortAlphabet : IComparer<Wordcs>
    {
        public int Compare(Wordcs x, Wordcs y)
        {
           return x.word.CompareTo(y.word);
        }
    }
}
