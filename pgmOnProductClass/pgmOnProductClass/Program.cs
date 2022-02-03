using System;

namespace pgmOnProductClass
{

    class product
    {
       
        public string name;
        public int price;
        public int quantity;


        public void ReadProduct()
        {
            
            Console.WriteLine("enter product name");
            name = Console.ReadLine();
            Console.WriteLine("enter price");
            price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter quantity");
            quantity = Convert.ToInt32(Console.ReadLine());

        }
        public void PrintProduct()
        {
            Console.WriteLine($"name={name},price={price},quantity{quantity}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p1 = new product();
            p1.ReadProduct();
            p1.PrintProduct();
        }
    }
}


