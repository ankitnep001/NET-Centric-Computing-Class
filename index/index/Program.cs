using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    internal class Program
    {
        class Employee
        {
            int[] Age = new int[3];
            public int this[int index]
            {
                set
                {
                    if (index >= 0 && index < Age.Length)
                    {
                        if (value > 0)
                        {
                            Age[index] = value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Value !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Index!!");
                    }
                }
                get
                {
                    return Age[index];
                }

            }
            public int this[int index, int i]
            {
                set
                {
                    Age[index] = value + i;
                }
                get
                {
                    return Age[index];
                }

            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[0] = -5;
            //emp[0,] = 5;
            Console.WriteLine(emp[0]);
            Console.Read();
        }
    }
}
