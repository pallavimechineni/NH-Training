using System;
// Author : M.Pallavi
// Purpose : Nullable Type C# Code Example.

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int? firstValue = 20;
            int? secondValue = null;

            if (firstValue.HasValue)
            {
                Console.WriteLine(firstValue.Value);

            }
            if (secondValue.HasValue)
            {
                Console.WriteLine(secondValue.Value);

            }


            Console.ReadKey();
        }
    }
}