using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            int summa=0;
            for (i=0; i<1000;i++)
            {
                if (i % 3 == 0|| i%5==0) 
                {
                    summa = summa + i;
                    
                }

                





            }
            Console.WriteLine(summa);
            Console.ReadKey();
        } 
    }
}
