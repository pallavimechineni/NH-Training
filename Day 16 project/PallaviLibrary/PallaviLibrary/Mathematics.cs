using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallaviLibrary
{
    public class Mathematics
    {
        int input;
        public void readdata()
        {
            Console.WriteLine("enter value");
            input =Convert.ToInt32(Console.ReadLine());
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
}
