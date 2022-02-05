using System;
namespace program3
{
    public class Employee
    {
        private int id;
        private string name;
        private int salary;
        public Employee()
        {
            this.id = 1;
            this.name = null;
            this.salary = 0;
        }
        public Employee(int eid, string ename, int esal)
        {
            id = eid;
            name = ename;

            salary = esal;

        }
        
        
        public void PrintEmployee()

        {
            Console.WriteLine($"id={id},name={name},salary={salary}");


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp1 = new Employee(12, "pallavi", 50000);
                emp1.PrintEmployee();
                Employee emp2 = new Employee();
                emp2.PrintEmployee();
                

            }
        }
    }
}


