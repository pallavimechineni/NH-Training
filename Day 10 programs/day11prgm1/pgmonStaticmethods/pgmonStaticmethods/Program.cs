using System;

namespace pgmonStaticmethods
{   /********************************************************************************
     Author : M.Pallavi
    purpose : Create Mathematics class and add 3 static methods and call the methods in main method.*/
    class Mathematics
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;

        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("addition is "+Mathematics.Add(5, 6));
                Console.WriteLine("substraction is "+Mathematics.Sub(9, 1));
                Console.WriteLine("multiplication is "+Mult(5, 6));



            }
        }
    }
}
