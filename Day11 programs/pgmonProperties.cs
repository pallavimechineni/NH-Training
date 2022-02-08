using System;

namespace pgmonPropert
{
    class Employee
    {   /*******************************************
        Author: M.Pallavi
        purpose: A sample code to illustrate properties */
        private int id;
        private string name;
        private string designation;
        private int salary;

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
            { salary = (designation == "s") ? 3000:6000;
                return salary; 
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
