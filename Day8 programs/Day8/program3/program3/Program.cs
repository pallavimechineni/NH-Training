using System;
using System.Linq;
namespace Day8
{
    internal class Program
    {
        class product
        {
            public int Id;
            public string Name;
            public int price;
            public string brand;
        }
        static void Main(string[] args)
        {
            product[] p = new product[]
            {
                new product(){Id = 1, Name = "mobile", price=570,brand = "Dell"},
                new product(){Id = 2, Name = "laptop",price=300, brand = "lenovo"},
                new product(){Id = 3, Name = "oven",price=309, brand = "philips"},
                new product(){Id = 4, Name = "television",price=490, brand = "LG"},
                new product(){Id = 5, Name = "refrigirator", price=690,brand = "whirlpool"},
            };

            Console.WriteLine("product list of price  >500 using for loop");
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].price > 500)
                {
                    Console.WriteLine($" product Name = {p[i].Name},  product brand = {p[i].brand}");
                }
            }
            Console.WriteLine("product list of price  >500 using foreach loop");
            foreach (var e in p)
            {
                if (e.price > 500)
                {
                    Console.WriteLine($" product Name = {e.Name},  product brand = {e.brand}");
                }  
            }
            Console.WriteLine("product list of price  >500 using  lamda");
            p.ToList().Where(e => e.price > 500).ToList().ForEach(e => Console.WriteLine($"ID = {e.Id}, brand = {e.brand}"));
            Console.ReadLine();
            Console.WriteLine("product list of price  >500 using for loop");
            var result = from d in p
                         where d.price > 500
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.WriteLine();

        }
    }
}
