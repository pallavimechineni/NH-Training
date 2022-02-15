using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pgmtoReadfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter w = new StreamWriter(@"D:\Day1 Assessment by Pallavi Mechineni\Day 15 project\pgmonQuizApplication\readtext.txt", true);

            w.WriteLine("appending using streamwriter");
            w.WriteLine("by using True to append ");

            w.Close();
            Console.WriteLine("\n Appending is done");

            //  Reading the File Content 
            StreamReader r = new StreamReader(@"D:\Day1 Assessment by Pallavi Mechineni\Day 15 project\pgmonQuizApplication\readtext.txt");

            r.ReadToEnd();

            r.Close();
            Console.WriteLine("\n Reading is done.");

            Console.ReadKey();
        }
    }
}
