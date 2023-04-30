using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void weekEnd()
            {
                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        Console.WriteLine("\tToday is Weekend.");
                        break;
                    default:
                        Console.WriteLine("Today is working day.");
                        break;
                }
            }
            weekEnd();
            Console.Read();
        }
    }
}
