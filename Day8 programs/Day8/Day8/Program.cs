using System;
using System.Linq;


namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 2, 4, 33, 44, 46, 57, 68, 87 };
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i]%2==0)
                {
                    Console.WriteLine(data[i]);
                }
            }
                foreach (int d in data)
                {
                    if (d % 2 == 0)
                    {
                        Console.WriteLine(d);

                    }
                }
                data.Where(d=>d% 2 == 0).ToList().ForEach(d => Console.WriteLine(d));
                var result = from d in data
                             where d % 2 == 0
                             select d;
                result.ToList().ForEach(d => Console.WriteLine(d));
                Console.WriteLine();


            }

        }

    }




    

