using System;

namespace pgmonOnlyPro
{
    /***************************************
    Author: M.Pallavi
    purpose: A sample code using only properties */


    internal class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Designation
            { get; set; }
        public int Salary
        {
            get
            {
                return (Designation == "S") ? 3000 : 6000;
               
            }


        }

    
    static void Main(string[] args)
        {
            
        Employee1 emp = new Employee1();
        emp.Id = 15;
        Console.WriteLine(emp.Id);
        emp.Designation = "L";
        Console.WriteLine(emp.Salary);

    }
}
}
