using System;
using System.Collections.Generic;
/********************************************************************
 Author: M.Pallavi
purpose : Find the first number after 1000 which is divisible by 97.
*********************************************************************/

namespace pgmOnbreak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1000; i <= 1097; i++)
            {

                if (i % 97 == 0) //check
                {
                    Console.WriteLine(i);
                    break;
                }

            }
            Console.ReadLine();
        }

    }
}