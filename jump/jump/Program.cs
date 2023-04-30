using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output ---goto---");
            jump_goto();
            Console.WriteLine("\nOutput ---break---");
            jump_break();
            Console.WriteLine("\nOutput ---continue---");
            jump_continue();
            Console.Read();
        }

        static void jump_goto()
        {
            Console.WriteLine("Jump: Goto statement");
            goto g;
            Console.WriteLine("This line will not be printed on console.");
        g:
            {
                Console.WriteLine("jumped to this line.");
            }
        }
        static void jump_break()
        {
            for (int i = 1; i <= 6; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine("\tline " + i);
            }
        }
        static void jump_continue()
        {
            for (int j = 1; j <= 6; j++)
            {
                if (j == 4)
                    continue;
                Console.WriteLine("\tline " + j);
            }
        }
    }
}
