using System;
using PallaviLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dllprogram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.readdata();
            Console.WriteLine(m.factorial());
            Console.ReadLine();
        }


    }
}        
    

