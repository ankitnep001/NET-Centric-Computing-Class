using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destruct
{

    class Person
    {
        public string Name;
        public int Age;
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }
        ~Person()
        {
            Console.WriteLine("Destructor has been invoked.");
            Console.ReadLine();
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Person Prishni = new Person("Prishni", 22);
                Console.WriteLine("Name:" + Prishni.getName());
                Console.WriteLine("Age:" + Prishni.getAge());
                Console.ReadKey();
          
            }
        }
    }
}
