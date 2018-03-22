using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SortNumberWords : IComparer<Wordcs>
    {
        public int Compare(Wordcs x, Wordcs y)
        {
            if (x.numberwords < y.numberwords)
                return 1;
            if (x.numberwords > y.numberwords)
                return -1;
            else return 0;
        }
    }
}
