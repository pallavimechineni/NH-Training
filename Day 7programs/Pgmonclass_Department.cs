using System;

namespace pgmonSeller
{
    using System;
    class Department
    {
        public string name;
        public int no;
        public string location;
        public void Readdept()
        {

            Console.WriteLine("enter department name");
            name = Console.ReadLine();
            Console.WriteLine("enter no");
            no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter location");
            location = Console.ReadLine();


        }
        public void Printdept()
        {
            Console.WriteLine($"name={name},no={no},location={location}");
        }

        internal class Program1
        {
            static void Main(string[] args)
            {
                Department d1 = new Department();
                d1.Readdept();
                d1.Printdept();
            }
        }


    }
    
}


