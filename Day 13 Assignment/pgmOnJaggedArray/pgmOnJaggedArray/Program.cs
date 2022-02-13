using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgmOnJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[6][];

            names[0] = new char[] { 'r', 'a', 'm','e','s','h' };
            names[1] = new char[] { 'k', 'r', 'i', 't', 'i' };
            names[2] = new char[] { 'n', 'b', 't', 'e', 'c', 'h', 'n', 'o', 'l', 'o', 'g', 'e', 's' };
            names[3] = new char[] { 'p', 'a', 'l', 'l', 'a', 'v', 'i' };
            names[4] = new char[] { 'c', 'h', 'a', 'i', 't', 'h', 'u' };
            names[5] = new char[] { 'c', 'o', 'm', 'p', 'a', 'n', 'y' };
            Console.WriteLine("printing array values ");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.ReadLine();
            }
        }

    }
}
