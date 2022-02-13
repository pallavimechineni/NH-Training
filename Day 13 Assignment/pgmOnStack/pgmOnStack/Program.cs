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
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());
           Console.WriteLine(data.Peek());
            Console.WriteLine(data.Count);
            Console.ReadLine();


        }
    }
}
