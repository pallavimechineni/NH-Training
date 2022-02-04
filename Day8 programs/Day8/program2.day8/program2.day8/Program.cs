using System;
using System.Linq;
namespace Day7Project5
{
    internal class Program
    {
        class Employee
        {
            public int empId;
            public string empName;
            public int empSalary;
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee(){empId = 1, empName = "pallavi", empSalary = 34000},
                new Employee(){empId = 2, empName = "lasya", empSalary = 25000},
                new Employee(){empId = 3, empName = "joshna", empSalary =33000},
                new Employee(){empId = 4, empName = "anusha", empSalary = 35000},
                new Employee(){empId = 5, empName = "Manoj", empSalary = 28000},
                new Employee(){empId = 6, empName = "rani", empSalary = 20000}
            };

            for (int i = 0; i < employees.Length; i++)
            {

                Console.WriteLine($"Employee ID = {employees[i].empId}, Employee Name = {employees[i].empName},  Employee Salary = {employees[i].empSalary}");
            }
            foreach (var e in employees)
            {
                Console.WriteLine($"Employee.ID = {e.empId},  Employee.Name = {e.empName},  Employee.Salary = {e.empSalary}");
            }

            employees.ToList().ForEach(e => Console.WriteLine($"ID = {e.empId},  Name = {e.empName},  Salary = {e.empSalary}"));

            Console.ReadLine();
            var result = from d in employees
                         where d.empId !=null
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.WriteLine();

        }
    }
}
