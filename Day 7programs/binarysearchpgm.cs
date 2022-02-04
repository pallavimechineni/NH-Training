using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int i, item, pos=0;
            int[] arr = new int[5];

            int LOW=0, HIGH, MID;
           
            //Read numbers into array
            Console.WriteLine("Enter elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element {0}: ", i);

                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter item to search : ");
            item = Convert.ToInt32(Console.ReadLine());
            HIGH = arr.Length - 1;
            MID = (LOW + HIGH) / 2;

            //Loop to search element in array.
            while (LOW <= HIGH)
            {
                if (item < arr[MID])
                {
                    HIGH = MID - 1;
                    MID = (LOW + HIGH) / 2;
                }
                else if (item > arr[MID])
                {
                    LOW = MID + 1;
                    MID = (LOW + HIGH) / 2;
                }
                else if (item == arr[MID])
                {
                    pos = MID + 1;
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