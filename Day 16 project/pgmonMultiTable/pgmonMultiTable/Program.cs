using System;

// Author : Pallavi mechineni
// Purpose : Printing Multiplication table of a given number using Object Oriented Approach.
namespace Day16Project3
{
    class Multi
    {
        int input;
       
        public int ReadInput()
        {

            Console.Write("\n Enter any Number To Print its Multiplication Table : ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Displaying the Multiplication Table for {0}", input);
            return input;
        }
        public void PrintTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
            }

            Console.WriteLine();
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                
                Multi table = new Multi();
                table.ReadInput();      
                table.PrintTable();  
                Console.ReadKey();
            }
        }
    }
}