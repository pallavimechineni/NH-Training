using System;

namespace pgmonPropert
{
    class employee
    {
        private int id;
        private string name;
        private string designation;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
      public string Name
        {
            get
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp=new emp();
            emp.Id = 25;
            Console.WriteLine(emp.Id);
            
            
        }
    }
}
