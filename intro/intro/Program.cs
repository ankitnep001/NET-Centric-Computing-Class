using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arithematicoperator();
            //compare();
            //logicaloperator();
            bitwiseoperator();
            Console.ReadLine();
        }

        static void arithematicoperator()
        {
            int a, b;
            Console.WriteLine("Enter two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(" Addition is {0}.\n Subtraction is {1}.\n Multiplication is {2}.\n Division is {3}.", a + b, a - b, a * b, a / b);
        }

        static void compare()
        {
            Console.WriteLine("  Enter two number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("  Given numbers are equal.");
            }
            else if (a < b)
            {
                Console.WriteLine("  {0} is less than {1}", a, b);
            }
            else
            {
                Console.WriteLine("  {0} is greater than {1}", a, b);
            }
        }


        static void logicaloperator()
        {
            Console.WriteLine("Enter your College name:");
            string collegename = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter your Program");
            string program = Console.ReadLine().ToUpper();
            if (collegename == "BMC" && program == "CSIT")
            {
                Console.WriteLine("You are welcome");
            }
            else
            {
                Console.WriteLine("Not welcome");
            }
        }

        static void bitwiseoperator()
        {
            Console.WriteLine("Enter two number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} | {1} = {2}", a, b, a | b);
            Console.WriteLine("{0} & {1} = {2}", a, b, a & b);
            Console.WriteLine("~{0} = {1}", a, ~a);
            Console.WriteLine("{0} << 1 = {1}", a, a << 1);
            Console.WriteLine("{0} >> 2 = {1}", a, a >> 2);

        }
    }
}
