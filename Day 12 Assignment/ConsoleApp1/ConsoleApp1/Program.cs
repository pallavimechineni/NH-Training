using System;

namespace ConsoleApp1
{
    namespace Hello_World
    {

        class Program
        {
            int result;

            Program()
            {
                result = 0;
            }

            public void division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }
            static void Main(String[] args)
            {
                Program d = new Program();
                d.division(16,4 );
                Console.ReadKey();
            }
        }
    }

}
