using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filesinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\csharp\filesinput\myfile.txt";
            FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
            file.WriteByte(30);
            Console.WriteLine("file written Successfully...");
            file.Close();
            Console.Read();
        }
    }
}
