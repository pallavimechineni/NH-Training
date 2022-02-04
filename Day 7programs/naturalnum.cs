using System;

namespace naturalnum
{
     public class naturalnum
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
                int inp = 0;  
            Console.WriteLine("enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; inp < n; inp++)
            {
                sum = sum + inp;
                Console.WriteLine("{0}", sum);

            }
            //for(int i=0;i<=n;i++)
            //{
            //    sum = sum + i;
            //   Console.WriteLine("{0}",sum);
            //}

            
 
            
        }
    }
}
