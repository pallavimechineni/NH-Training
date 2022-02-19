using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Factorial
    {
        int n;
        public void Readinput()
        {
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());

        }
        public int Fact()
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;

            }
            return fact;
           
        }
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            f.Readinput();
            Console.WriteLine("{0}",f.Fact());
            Console.ReadLine();
        }
       
    }
}

