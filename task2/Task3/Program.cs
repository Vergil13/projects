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
            int[] arr = new int[32];
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < 32; i++)
            {
                arr[i]= random.Next(-32, 32);
                
                if (arr[i] > 0)
                {
                    
                    sum += arr[i];


                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            
        }
    }
}
