using System;

namespace prgm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3,2] { { 5, 2 }, { 6, 3 }, { 4, 2 } };
            for (int i = 0;i<3;i++)
            {
                for (int j = 0;j<2;j++)
                {
                    Console.Write(data[i,j] +"\t" );
                }
                Console.WriteLine();
            }
        }
    }
}
