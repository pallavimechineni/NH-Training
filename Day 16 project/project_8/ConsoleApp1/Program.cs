using System;
using mathlibrary;
using phylibrary;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.Readdata();
            Console.WriteLine("factorial of number is{0}", + m.Factorial());
            Physics p = new Physics();
            Console.WriteLine("velocity is " + p.Velocity(3, 4, 5));
            Console.ReadLine();


        }
    }
}
