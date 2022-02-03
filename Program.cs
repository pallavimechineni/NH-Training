using System;

namespace ConsoleApp2
{
    internal class Program
    {
        class employee
        {
            public int id;
            public string name;
            public int age;
            public int salary;
        }
        static void Main(string[] args)
        {
            employee e=new employee() { id = 1, name = "rrr",age = 24, salary = 25};
            
            
            Console.WriteLine($"id={e.id},name={e.name},age={e.age},salary={e.salary}");
                
        }
    }
}
