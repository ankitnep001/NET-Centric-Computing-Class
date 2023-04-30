using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ashynch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.Read();
        }
        public static void Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var task1 = StartSchoolAssembly();
            var task2 = TeachClass0();
            var task3 = TeachClass1();
            Task.WaitAll(task1, task2, task3);
            watch.Stop();
        }
        public static async Task StartSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("School Started");
            });
        }
        public static async Task TeachClass1()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class 8");
            });
        }
        public static async Task TeachClass0()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class 9");
            });
        }
    }
}
