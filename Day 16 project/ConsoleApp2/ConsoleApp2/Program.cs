using System;
using pgmLibray3classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            mathematics m = new mathematics();
            m.readdata();
            Console.WriteLine("factorial of number is" +m.factorial());
            physics p = new physics();
            Console.WriteLine("velocity is " +p.Velocity(3, 4, 5));
            chemistry c = new chemistry();
            Console.WriteLine("benezene value is " +c.benzene());
            Console.WriteLine("water formula is" +c.water());
            Console.ReadLine();
        }


    }
 }
    

