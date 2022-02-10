using System;

namespace ConsoleApp1
{
    public class Program
    {
        private int a;
        private int b;
        public int A
        {
            set { a = value; }
            get { return a; }
        }

        public int B
        {
            set { b = value; }
            get { return b; }
        }


        public static void Main(string[] args)
        {

            Program p = new Program();
            p.A = 23;
            p.B = 54;
            Console.WriteLine("value of a is" + p.A);
            Console.WriteLine("value of b is"+ p.B);
        }

    }
}
    