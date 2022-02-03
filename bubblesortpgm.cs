using System;
namespace Programs
{
class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] data= new int[5];
            Console.WriteLine("Enter the Array Elements : ");
            for (int i = 0; i < data.Length; i++)
            {
                data[i] =Convert.ToInt32(Console.ReadLine());
            }
            //Sorting the array
            for (int j = 0; j <= data.Length - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= data.Length - 2; i++)
                {
                    count = count + 1;
                    if (data[i] > data[i + 1])
                    {
                        int temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting Array :");
            foreach (int item in data)
            {
                Console.WriteLine(item);
            }
           ;
            
            Console.ReadKey();
        }
    }
}