using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int i ;
            int item;
            int pos = 0;

            int[] arr = new int[5];

            //Read numbers into array
            Console.WriteLine("Enter elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter item to search : ");
            item = Convert.ToInt32(Console.ReadLine());

            //Loop to search element in array.
            for (i = 0; i < arr.Length; i++)
            {
                if (item == arr[i])
                {
                    pos = i + 1;
                    break;
                }
            }

            if (pos == 0)
            {
                Console.WriteLine("Item Not found in array");
            }
            else
            {
                Console.WriteLine("Position of item in array: " + pos);
            }

        }
    }
}