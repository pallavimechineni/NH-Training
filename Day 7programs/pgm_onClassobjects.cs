using System;

namespace pgmClassObjects
{
    class customer
    {
        public int id;
        public string name;
    
    public void ReadCustomer()
    {
        Console.WriteLine("enter id");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter name");
        name = Console.ReadLine();
    }
    public void PrintCustomer()
    {
        Console.WriteLine($"id={id},name={name}");
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.ReadCustomer();
            c1.PrintCustomer();
        }
    }
}