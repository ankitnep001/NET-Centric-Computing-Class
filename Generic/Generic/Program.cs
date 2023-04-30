using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        class Example
        {
            public static void ShowArray<T>(T[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            public static bool Check<T>(T a, T b)
            {
                bool c = a.Equals(b);
                return c;
            }
        }

        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 11;
            Numbers[1] = 22;
            Numbers[2] = 33;
            string[] Names = { "Prishni", "Smrity", "Sudikshya" };
            double[] Pints = { 4.0, 3.5, 3.6 };
            Example.ShowArray(Numbers);
            Console.WriteLine("_____________________________");
            Example.ShowArray(Names);
            Console.WriteLine("_____________________________");
            Example.ShowArray(Pints);
            Console.WriteLine("_____________________________");
            Console.WriteLine(Example.Check(10, 20));
            Console.WriteLine(Example.Check("Ankit", "Ankit"));
            Console.WriteLine(Example.Check('A', 'B'));
            Console.Read();

        }
    }
}
