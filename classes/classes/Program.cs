using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ankit = new Person();
            ankit.noOfEyes = 2;
            // Bipin.numberOfEyes = 2; This is not accessible because field numberOfEyes' is private.
            ankit.hairColor = "Black";
            Console.WriteLine("You have " + ankit.noOfEyes + " eyes.");
            Console.WriteLine("You have " + ankit.hairColor + " hair");
            ankit.EatingHabit();
            ankit.EatingHabit("chicken");
            Console.WriteLine("I also love eating " + ankit.EatHabit("mango"));
            Console.Read();
        }
    }
}
