using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program5
{  /* Author : M.Pallavi
      Purpose : program to print sum of two matrices.
   */
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[,] array1 = new int[2, 2];
            int[,] array2= new int[2, 2];
            int[,] array3 = new int[2, 2];
            Console.WriteLine("enter first matrix");
            //read 1st matrix
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
                //read 2nd matrix
                Console.WriteLine("enter second  matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }      


                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        array3[i, j] = array1[i, j] + array2[i, j];

                    }
                }
            Console.WriteLine($"sum of 2 matrices is ");

            for ( int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n");

                for (int j=0;  j < 2; j++)
                    {
                        
                    Console.Write(("\t" + array3[i, j] + " ") );

                    }
                }

                Console.WriteLine("\n");
            Console.ReadLine();
        }
            
    }
    }

