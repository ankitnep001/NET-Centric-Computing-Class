using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class VisitEmployee : Employee
    {
        public int VisitingSalary;
        public int VisitingHours;
    }

    class PermanentEmployee : Employee
    {
        public int PermanentSalary;
        public int PermanentHours;
    }

    class Employee
    {
        public int EId;
        public string EName;
        public int EAge;
        public int EContact;

        public void show()
        {
            Console.WriteLine("this is a method of parent class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee Aarya = new PermanentEmployee();
            Aarya.EId = 1;
            Aarya.show();

            VisitEmployee Ajay = new VisitEmployee();
            Ajay.EId = 2;

            Console.WriteLine("Aarya ID: "+ Aarya.EId);
            Console.WriteLine("Ajay ID: "+ Ajay.EId);
            Console.Read();
        }
    }
}
