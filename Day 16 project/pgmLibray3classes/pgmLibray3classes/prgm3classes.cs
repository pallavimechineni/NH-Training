using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgmLibray3classes
{
    public class mathematics
    {
        int input;
        public void readdata()
        {
            Console.WriteLine("enter value");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public int factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    public class chemistry
    {
        public string benzene()
        {
            return "C6H6";
        }
        public string water()
        {
            return "H20";
        }
    }
    public class physics
    {
        public int Velocity(int u, int a, int t)
        {
            return u + a * t;
        }
    }


}    
