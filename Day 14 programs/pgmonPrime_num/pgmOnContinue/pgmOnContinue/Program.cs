using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgmOnContinue
{
/********************************************************************************************
 Author: M.Pallavi    
purpose: WACP to print numbers from 1 to 30 and skip the numbers divisible by 3 using  continue;
**********************************************************************************************/
internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter n value");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numbers not divisible by 30 are");
            for (int i = 0; i <= n; i++)
            {
                
                if (i % 3 == 0)
                    continue;
                Console.Write(i + "\t");

            }
        Console.ReadLine();
        }

    }
}
