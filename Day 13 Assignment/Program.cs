using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgmOnStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(1);
            data.Push(2);
            data.Push(3);
            data.Push(4);
            data.Push(5);
            Console.WriteLine("total no.elements are " +data.Count);
            Console.WriteLine("poped element is " +data.Pop());
           Console.WriteLine("peek element is"+data.Peek());
            Console.WriteLine("count is " +data.Count);
            Console.ReadLine();


        }
    }
}
