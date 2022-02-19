using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Math2Library
{
    public static partial class Mathematics
    {
        public static int Modulus(int a, int b)
        {
            int Mod = a %b;
            Console.WriteLine(Mod);
            return Mod;
        }
    }
}