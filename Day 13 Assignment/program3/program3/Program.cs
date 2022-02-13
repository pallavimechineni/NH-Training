using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    internal class Program
    {   /* program on 2D array to print trace of array*/
        static void Main(string[] args)
        {

            int[,] data = new int[,] { { 1, 2, 3 }, { 4, 1, 8 }, { 3, 4, 9 } };
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(data[i, j] + "  ");
                }
                Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum = sum + data[i, j];
                    }
                }

            }
            Console.WriteLine("\n The Trace of the array is : {0}", sum);
            Console.ReadLine();

        }


    }
}

