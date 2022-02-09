using System;

namespace pgmon2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2,2];
            data[0, 0] = 2;
            data[0, 1] = 3;
            data[1, 0] = 4;
            data[1, 1]= 5;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j] + "\t");
                }
            Console.WriteLine("\n");
            }

        }
    }
}

            

            