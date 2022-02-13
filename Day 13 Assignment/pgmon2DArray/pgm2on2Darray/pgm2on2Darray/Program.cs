using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pgm2on2Darray
{  /*Declare a 2-D array of size (3,2) and initialize in the same line while declaring and print the values using nested for loop*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 1, 2 }, { 4, 1 }, { 3, 4 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + "  ");
                }
                Console.Write("\n");
            }
             Console.ReadLine();
        }
    }

}