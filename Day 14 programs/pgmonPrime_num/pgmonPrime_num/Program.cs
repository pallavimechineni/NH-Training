using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgmonPrime_num
{  /*****************************************************************
    Author: program to check given number is prime or not
    ******************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 81;
            
            for (int i = 2; i < n; i++)//check for prime
            {
                if (n % i == 0)
                    break;


                if (i == n)
                {
                    Console.WriteLine("prime number");
                }
                else
                    Console.WriteLine("not prime number");
            }
            Console.ReadLine();
        }

    }
}
