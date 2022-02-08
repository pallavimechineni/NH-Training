using System;

namespace pgmonMethodOverloading
{
    class Program
    {
        public void Display(int a)
        {
            Console.WriteLine(a);
        }
        public void Display(int a, int b)
        {
            Console.WriteLine("by using overloading");
            Console.WriteLine(a + b);

        }
    }

    internal class Program1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Display(10);
            p.Display(11, 14);
            Console.ReadLine();
        }
    }
}



