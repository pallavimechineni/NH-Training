using System;
using ClientPrgm.ServiceReference1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPrgm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WebService1SoapClient w = new WebService1SoapClient();
           Console.WriteLine(w.Add(1, 2));
            Console.WriteLine(w.Div(1, 2));
            Console.WriteLine(w.Mul(1, 2)) ;
            Console.WriteLine(w.Factorial(5));
            Console.ReadLine();
        }
    }
}
