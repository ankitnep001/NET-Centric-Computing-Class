using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comstruct
{
    internal class Employee
    {
        int EId;
        string EName;
        int EAge;
        public Employee()
        {
            Console.WriteLine("This is first constructor");
        }

        public Employee(int EId, string EName, int EAge)
        {
            this.EId = EId;
            this.EName = EName;
            this.EAge = EAge;
            Console.WriteLine("This is third constructor");
        }

        public Employee (int EId,string EName)
        {
            Console.WriteLine("This is a 2nd comstructor");
        }
        static void Main(string[] args)
        {
            Employee p = new Employee();
            Employee q = new Employee(101,"Mark");
            Employee r = new Employee(102,"Steve", 45);
            Console.Read();
        }
    }
}
