using System;

namespace day11prgm1
{
    interface Ishape
    {
        int Calperimeter();
        int Calarea();
    }
    class Circle : Ishape
    {
        int radius;
        public void Readradius()
        {
            Console.WriteLine("enter radius of circle");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        public int Calarea()
        {
            return 22 * radius * radius / 7;

        }

        public int Calperimeter()
        {
            return 2 * 22 * radius * radius / 7;
        }
    }
    class Square : Ishape
    {
        private int side;

        public void Readradius()
        {
            Console.WriteLine("enter length of side");
            side = Convert.ToInt32(Console.ReadLine());
        }

        public int Calarea()
        {
            return side * side;

        }
        public int Calperimeter()
        {
            return 4 * side;
        }
    }
    class Rectangle : Ishape
    {
        private int length, breadth;

        public void Readsides()
        {
            Console.WriteLine("enter length rectangle");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth rectangle");
            breadth = Convert.ToInt32(Console.ReadLine());
        }

        public int Calarea()
        {
            return length * breadth;
        }
        public int Calperimeter()
        {
            return 2 * (length + breadth);
        }
    }
    class Triangle : Ishape
    {
        private int breadth, height;

        public void ReadTsides()
        {
            Console.WriteLine("enter length of triangle");
            breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth of triangle");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public int Calarea()
        {
            return breadth * height / 2;
        }

        public int Calperimeter()
        {
            return breadth + height;
        }

    }

    internal class program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Readradius();
            Console.WriteLine(c.Calarea());
            Console.WriteLine(c.Calperimeter());
            Square s = new Square();
            s.Readradius();
            Console.WriteLine(s.Calarea());
            Console.WriteLine(s.Calperimeter());
            Rectangle r = new Rectangle();
            r.Readsides();
            Console.WriteLine(r.Calarea());
            Console.WriteLine(r.Calperimeter());
            Triangle t = new Triangle();
            t.ReadTsides();
            Console.WriteLine(t.Calarea());
            Console.WriteLine(t.Calperimeter());

            Console.ReadLine();
        }

    }
}



