
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[5];
            {
                    new Employee() { id = 1, name = "ram", salary = 20000 };
                    new Employee() { id = 2, name = "sita", salary = 10000 };
                    new Employee() { id = 3, name = "ravi", salary = 50000 };
                    new Employee() { id = 4, name = "hina", salary = 20000 };
                    new Employee() { id = 5, name = "vani", salary = 60000
                };
                for (int i = 0; i < emp.Length; i++)
                {
                    Console.WriteLine($"id={emp[i].id},name={emp[i].name},salary={emp[i].salary}");
                }
                foreach (var e in emp)
                {
                    Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
                }
               //lamda 
               emp.ToList(foreach(e =>Console.WriteLine(($"id={e.id},name={e.name},salary={e.salary}"));
               
        

        }
    } 
