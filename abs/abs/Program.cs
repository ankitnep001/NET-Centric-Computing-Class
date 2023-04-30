using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abs
{
    public abstract class person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string ContactNumber;
        public abstract void PrintDetails();
    }

    class student : person
    {
        public int RollNo;
        public int Fees;
        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Name of Student: " + name);
            Console.WriteLine("Age of Student: " + this.Age);
            Console.WriteLine("Contact Number of Student: " +
           this.ContactNumber);
            Console.WriteLine("Student Roll Number: " + this.RollNo);
            Console.WriteLine("Student Fees: " + this.Fees);
        }
    }

    class professor : person
    {
        public string Qualification;
        public int Salary;
        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Professor's Name: " + name);
            Console.WriteLine("Professor's Age: " + this.Age);
            Console.WriteLine("Professor's Contact Number: " +
           this.ContactNumber);
            Console.WriteLine("Qualification: " + this.Qualification);
            Console.WriteLine("Salary: " + this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            student Prishni = new student();
            Prishni.FirstName = "Prishni";
            Prishni.LastName = "Ghimire";
            Prishni.Age = 22;
            Prishni.ContactNumber = "984163627";
            Prishni.RollNo = 09;
            Prishni.Fees = 35125;
            Prishni.PrintDetails();
            Console.WriteLine("================================");
            professor Ramesh = new professor();
            Ramesh.FirstName = "Ramesh";
            Ramesh.LastName = "kharbuja";
            Ramesh.Age = 49;
            Ramesh.ContactNumber = "9834272737";
            Ramesh.Qualification = "IT";
            Ramesh.Salary = 500000;
            Ramesh.PrintDetails();
            Console.Read();

        }
    }
}
