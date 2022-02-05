using System;
namespace program_1
{
    class Mathtask
    {
        private int input;
        public void ReadInput()
        {
            Console.WriteLine("enter number");
            input = Convert.ToInt32(Console.ReadLine());

        }
        
        public void PrintFactors()
        {
            for (int i = 1; i <= input; i++)

            {
                if (input % i == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }

        public bool IsPrime()
        {
            int count = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                    count++;


            }
            if (count == 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Facto()
        {
            Console.WriteLine("enter factorial number");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;


            }
            Console.WriteLine(fact);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathtask obj = new Mathtask();
            obj.ReadInput();
            

            obj.PrintFactors();
            if (obj.IsPrime() == true)
            {
                Console.WriteLine("input is prime");
            }
            else
                Console.WriteLine("input is not prime");

            obj.Facto();
        }
    }

}

