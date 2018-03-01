using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            String t = "*";
            Console.WriteLine("Введите число строк");
            

            int a = Int32.Parse(Console.ReadLine());
            for ( int i=0; i<a; i++)
            {
               
                t += "*";
                Console.WriteLine(t);
                
               
            }
            Console.ReadKey();
        } 
    }
}
