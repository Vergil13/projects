using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randoms
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] GreatMassiv = new int[10];
            for (int i = 0; i < GreatMassiv.Length; i++)
            {
                GreatMassiv[i] = random.Next(-10, 10);

            }
            Writeconsolemassive(GreatMassiv);

        }

        public static void Sort(int[] GreatMassiv)
        {
            int temp;
            for (int i = 0; i < GreatMassiv.Length; i++)
            {
                for (int j = i - 1; j < GreatMassiv.Length; j--)
                {
                    if (GreatMassiv[i] > GreatMassiv[j])
                    {
                        temp = GreatMassiv[i];
                        GreatMassiv[i] = GreatMassiv[j];
                        GreatMassiv[j] = temp;
                    }
                   

                }
            }



        }
        static void Writeconsolemassive(int[] greatmassiv)
        {
            foreach (int element in greatmassiv)
                Console.WriteLine($"{element}");
            Console.WriteLine(" ");
            Console.WriteLine(Maximum(greatmassiv));
            Console.WriteLine(Minimum(greatmassiv));
            Console.ReadKey();
        }

        static int Maximum(int[] greatmassiv)
        {
            int max = greatmassiv[0];

            for (int i = 0; i < greatmassiv.Length; i++)
            {

                if (greatmassiv[i] > max) max = greatmassiv[i];



            }
            return max;


        }

        static int Minimum(int[] greatmassiv)
        {
            Random radnom = new Random();

            int min = int.MaxValue;
            for (int i = 0; i < greatmassiv.Length; i++)
            {
                if (min > greatmassiv[i])
                {
                    min = greatmassiv[i];
                }

            }
            return min;
        }
    }
}