using System;

namespace program_8b
{    class Subject
    {
        public virtual void Study()
        {
            Console.WriteLine("study mathematics");
        }
    }
    class  Maths  :Subject
    {
        public  override void Study()
        {
            Console.WriteLine("study maths");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths s = new Maths();
            s.Study();
        }
    }
}
