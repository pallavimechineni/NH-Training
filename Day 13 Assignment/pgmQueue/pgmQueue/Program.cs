using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgmQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(1);
            data.Enqueue(2);
            data.Enqueue(3);
            data.Enqueue(4);
            data.Enqueue(5);
            data.Enqueue(6);
            Console.WriteLine("no of elements in queue is " + data.Count);
            Console.WriteLine("the element removed is " + data.Dequeue());
            Console.WriteLine("last element is " + data.Peek());
            Console.WriteLine("no of elements is " + data.Count);
            Console.ReadLine();
        }
       

    }
}

        
    

