using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {   
        public void Print()
        {
            Console.WriteLine("hello world");//printing hello world
        }
        static void Main(string[] args)
        { 
            Program p=new Program();//creating object for class program
            p.Print();//calling method  by using object
            Console.ReadLine();
        }
      
    }
}
