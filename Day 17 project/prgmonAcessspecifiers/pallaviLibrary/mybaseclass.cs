using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pallaviLibrary
{
    public  class mybaseclass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        int e;
        public void method()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;


        }
    }
    public class myderivedclass : mybaseclass
    {
        public void myderivedmethod()
        {   
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
            

        }
    }
    public class Otherclass
    {
        public void otherclass()
        {
            

        mybaseclass mb = new mybaseclass();
        mb.a  = 1;
        mb.b =2;
        mb.c=3;
        mb.d=4;
         mb.e=5;

          
        }

    }
}
    

