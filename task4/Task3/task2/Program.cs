using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string StringOne = "";
            string Stringtwo = "";
            string Result = "";
            Console.WriteLine("Введи первую строку");
            StringOne = Console.ReadLine();
            Console.WriteLine("Введи вторую строку");
            Stringtwo = Console.ReadLine();
            foreach (char ch in StringOne)
                if (!Stringtwo.Contains(ch))
                    Result += ch;
                else
                {
                    Result += ch;
                    Result += ch;
                }
            Console.WriteLine("Результат = {0}", Result);
            Console.ReadKey();
        }
       
        



        }
}

