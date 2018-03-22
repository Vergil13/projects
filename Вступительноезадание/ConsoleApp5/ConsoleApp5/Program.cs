using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write pass");
            Sorting newsorting = new Sorting();


            //наш прекрасный массив string
            string[] keywords = new string[]
            {
               "abstract", "as", "base", "bool",
                "break", "byte", "case", "catch",
                "char", "checked", "class", "const",
                 "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false",
                 "finally", "fixed", "float", "for","foreach", "goto", "if", "implicit","in" , "int", "interface","internal","is", "lock", "long",
                 "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected","public",
                 "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc","static", "string", "struct", "switch",
                 "this", "throw", "true", "try","typeof", "uint", "ulong", "unchecked", "unsafe", "ushort","using", "virtual", "void", "volatile","while"
            };
            //as 
            newsorting.ReadingPath();
            List<string> newlist = new List<string>(newsorting.GetListKeyWords(keywords,newsorting.CleanerTextProgram()));
            Console.ReadKey();
        }
            
    }
}

