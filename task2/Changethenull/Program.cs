using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changethenull
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[,,] arr = new int[2, 2,2];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++) 
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                    
                        arr[i,j,k]= random.Next(-99, 100);
                         if (arr[i,j,k]>0)
                         {
                          arr[i, j, k] = 0;

                            
                         }
                        Console.WriteLine(arr[i, j, k]);
                    }
            Console.ReadKey();
           

        }
        
    }
}
