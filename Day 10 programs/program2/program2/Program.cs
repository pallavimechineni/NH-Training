using System;

namespace program2
{
    class GrandFather
    {
        public int age = 53;
        public void Display()
        {
            Console.WriteLine("grandfather");
        }

    }
    class Father : GrandFather
    {
        public int Age = 45;
        public void Displayf()
        {
            Console.WriteLine("father ");
        }
    }
    class son : Father
    {
        public int Sage = 23;
        public void DisplayS()
        {
            Console.WriteLine("son");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            son s = new son();
            s.Display();
            Console.WriteLine(s.age);
            s.Displayf();
            Console.WriteLine(s.Age);
            s.DisplayS();
            Console.WriteLine(s.Sage);
            Console.ReadLine();
        }
    }



}
