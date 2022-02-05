using System;
namespace program3
{
    public class Employee
    {
        private int id;
        private string name;
        private int salary;
        private string companyname;
        public void ReadInput()
        {
            Console.WriteLine("enter id ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter NAME ");
            name = Console.ReadLine();
            Console.WriteLine("enter salary ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()

        {
            Console.WriteLine($"id={id},name={name},salary={salary}");


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp1 = new Employee();
                Employee emp2 = new Employee();
                emp1.ReadInput();
                emp1.PrintEmployee();
                emp2.ReadInput();
                emp2.PrintEmployee();

            }
        }
    }
}