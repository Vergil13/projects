using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string t = Console.ReadLine();
            Console.WriteLine(ReturnAverageWords(t));
            Console.ReadKey();
        }
        static public int ReturnAverageWords(string args)
        {
            string[] array = args.Split(new[] { ' ', ',', ';', ':', '-', '?',  },StringSplitOptions.RemoveEmptyEntries );
            int summ = 0;
            for (int i= 0; i < array.Length; i++)
            {
                 summ+=array[i].Length;

            }
            int average = summ / array.Length;
            return average;

        }

    }
}
