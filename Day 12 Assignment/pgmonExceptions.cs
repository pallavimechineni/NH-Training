using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try {
            int a, b, c;
            Console.WriteLine("enter a numnber");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value");
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine("answer is= { 0}", c);
            Console.ReadLine();
        }

        catch (OverflowException)
        {
            Console.WriteLine("only numbers between 0 and 5000000 are allowed");

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("cannot divide with zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("ONLY NUMBERS Are allowed");
        }
    catch(Exception)
        {
            Console.WriteLine("some error occured please contact @Admin.Mycompany.com");
        }
    }

}
