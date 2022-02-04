using System;

namespace Day7classprograms
{
    class employee
    {
        public int id;
        public string name;
        public int salary;
        public void ReadEmployee() //Reading employee details
        {
            Console.WriteLine("enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee() //printing employee details
        {
            Console.WriteLine($"id={id},name={name},salary={salary}");

        }


        internal class Program
        {

            static void Main(string[] args)
            {
                employee emp1 = new employee();
                employee emp2 = new employee();
                emp1.ReadEmployee();
                emp2.ReadEmployee();
                emp1.PrintEmployee();

                emp2.PrintEmployee();
            }
        }
    }
}
