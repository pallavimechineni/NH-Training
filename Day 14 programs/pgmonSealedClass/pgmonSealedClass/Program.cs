using System;
/******************************************************
 * Author: M.Pallavi
 purpose: program on sealed class.
********************************************************/

namespace pgmonSealedClass
{
    sealed class police
    {
        public static int helpline = 100;
        public int secret()
        {
            return 89;
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            police p=new police();
            Console.WriteLine(p.secret());
        }
    }
}
