using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            string stars = "*";
           
            Console.WriteLine("Введите число строк");
            int weidhtTriangle;
            int emptiness;
            weidhtTriangle = Int32.Parse(Console.ReadLine());
            for (int i= 1;i<weidhtTriangle; i++ )
            {
                string b = "";
                string result = "";
                emptiness = weidhtTriangle-i;
                stars = new string('*',i*2-1);
                b=b.PadLeft(emptiness);
                result = b+ stars;
                
                Console.WriteLine(result);
                
            }
            Console.ReadKey();

                
         }

            
    }
}
