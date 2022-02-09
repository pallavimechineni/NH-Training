using System;

namespace pgmonPropert
{
    class Employee
    {   /*******************************************
        Author: M.Pallavi
        purpose: A sample code to illustrate properties */
        private int Id;
        private string Name;
        private string Designation;
        private int Salary;

        public int Id//creating id property
        {
            get { return id; }
            set { id = value; }
        }
      public string Name//creating name property
        {
            get { return name; }
            set { name = value; }
        }
        public string Designation //creating designation property
        {
            get { return designation; }
            set { designation = value; }
        }
        public int Salary
        {
            get 
            { Salary = (designation == "s") ? 3000:6000;
                return Salary; 
            }

            set { salary = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee();
            emp.Id = 25;
            Console.WriteLine(emp.Id);
            emp.Designation = "S";
            Console.WriteLine(emp.Salary);
            
        }
    }
}
