﻿using System;

// Author : M.Pallavi
// Purpose : Delegate Example

namespace DelegatesExamp
{
    public delegate void rectDelegate(double height, double width);
    class Rectangle
    {
        
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

       
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Rectangle rect = new Rectangle();

            
            rectDelegate rectdele = new rectDelegate(rect.area);

           
            rectdele = rectdele+rect.perimeter;

            
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            
            rectdele.Invoke(16.3, 10.3);
            Console.ReadLine();
        }
    }
}