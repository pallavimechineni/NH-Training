using System;
// Author : M.Pallavi
// Purpose : C# Code to illustrate, the Ref & Out keywords.
namespace ConsoleApplication1
{
    class Refexam
    {
        public void show(ref int x, out int y)
        {
            y = x % 2;
            x = x / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int reminder;
            Refexam obj = new Refexam();
            
            a = 35;
            Console.WriteLine("before call a :" + a);// this will display 35
                                                     
            obj.show(ref a, out reminder);
            Console.WriteLine("after call a :" + a);// this will display 17
            Console.WriteLine("before call a :" + reminder); 
            Console.ReadKey();
        }
    }
}