using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPUT A");
            double a=Double.Parse(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("Why you so stupied . Choose another numbers");
                a = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Imput b");
            double b=Int32.Parse(Console.ReadLine());
            while (b <= 0)
            {
                Console.WriteLine("Why you so stupied . Choose another numbers");

                b = Double.Parse(Console.ReadLine());
            }
            double s = a*b;
            Console.WriteLine("Your rectangle" +  (s));
            Console.ReadKey();
        }
    }
}
