using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            for (int x=0; x<50; x++)
            {
                TimeSpan timeSpan = new TimeSpan();
                Stopwatch stopwatch = new Stopwatch();
                string str = "";
                 N *=2;
                stopwatch.Start();
                for (int i = 0; i < N; i++)
                {
                    str += "*";
                }
                stopwatch.Stop();
                timeSpan = stopwatch.Elapsed;
                Console.WriteLine($"Это цифры работы string     N = {N}  " +  timeSpan.TotalMilliseconds);
                stopwatch.Reset();
                stopwatch.Start();
                
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < N; i++)
                {
                    sb.Append("*");
                }
                stopwatch.Stop();
                timeSpan = stopwatch.Elapsed;
                Console.WriteLine($"Это цифры работы stringbuilder N = {N}   " + timeSpan.TotalMilliseconds+"\n");
            }
            Console.ReadKey();
        }      
    }
}
