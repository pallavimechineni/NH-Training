using System;

namespace program2
{
    public class numbers
    {
        private int a;

        private int b;

        public void ReadInput()
        {
            Console.WriteLine("enter a value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b valu");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public int Addnum()
        {
            return a + b;
        }
        public int Subnum()
        {
            return a - b;
        }
        public int Mulnum()
        {
            return a * b;
        }
        public int Div()
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            numbers obj = new numbers();
            obj.ReadInput();
            Console.WriteLine("sum of 2 numbers");
            Console.WriteLine(obj.Addnum());
            Console.WriteLine("subtraction of 2 numbers");
            Console.WriteLine(obj.Subnum());
            Console.WriteLine("muultiplication of 2 numbers");
            Console.WriteLine(obj.Mulnum());
            Console.WriteLine("division of 2 numbers");
            Console.WriteLine(obj.Div());

        }
    }
}


