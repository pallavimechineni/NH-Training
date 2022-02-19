using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathlibrary
{
    public class Mathematics
    {
        int input;
        public void Readdata()
        {
            Console.WriteLine("enter value");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public int Factorial()
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
