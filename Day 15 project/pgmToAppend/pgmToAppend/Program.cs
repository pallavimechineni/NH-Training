using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pgmToAppend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StreamWriter sw = new StreamWriter(@"D:\Day1 Assessment by Pallavi Mechineni\Day 15 project\programToAppend.txt");
            sw.WriteLine("Hi ");
            sw.WriteLine("This is a File Operation using Sw with WriteLine Method");
            sw.Close();
            Console.WriteLine("Writing File Is done\n");
            StreamWriter w = new StreamWriter(@"D:\Day1 Assessment by Pallavi Mechineni\Day 15 project\programToAppend.txt", true);

            w.WriteLine("by using  Stream Writer,");
            w.WriteLine("using Append True");
            w.Close();
            Console.WriteLine(" Appending is done");

            Console.ReadKey();
        }
    }
}
