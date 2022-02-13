using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];

            
            for (int i = 0; i < 2; i++)// Reading elements from the user
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter the array elements ");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Printing the Array elements
            Console.WriteLine(" array items are");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("\t" + data[i, j] + " ");
                }
                Console.ReadLine();
            }
            
        }
    }
}
