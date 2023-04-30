using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace loops
{
    internal class Program
    {
        static void forLoop()
        {
            int i = 5;
            for (; i <= 10;)
            {
                Console.WriteLine(i);
                i++;

            }
        }
        static void foreachloop()
        {
            string[] fruits = { "Banana", "Apple", "Orange", "Mango" };
            foreach (string x in fruits)
            {
                Console.Write( x + "\t");
            }
        }

        static void whileLoop()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.Write(i + "\t");
                i++;
            }
        }

        static void doWhileLoop()
        {
            int x = 0;
            do
            {
                Console.Write("x= " + x + "\t");
                x++;
            } while (x <= 5);
        }

        static void Main(string[] args)
        {
            //forLoop();
            //foreachloop();
            //whileLoop();
            Console.Read();
        }
    }
}
