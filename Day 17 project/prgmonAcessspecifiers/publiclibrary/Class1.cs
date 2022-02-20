using System;
using pallaviLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publiclibrary
{
    public class Class1 : mybaseclass
    {
        public void derivedmethod()
        {

            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;

        }
    }
    public class otherclass
    {
        public void othermethod()
        {
             mybaseclass m=new mybaseclass();   
            m.a = 1;
            m.b = 2;
            m.c = 3;
           m. d = 4;
            m.e = 5;

        }
    }
}

