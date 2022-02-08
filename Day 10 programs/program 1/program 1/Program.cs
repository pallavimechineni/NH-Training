using System;

namespace program_1
{
    class Animal
        {
       public  string name="dog";
    public void Display()
    {
        Console.WriteLine(" wild animal");
    }
}
    class Dog : Animal
    {
        public void GetName()
        {
            Console.WriteLine("Tiger ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d=new Dog();
            
            Console.WriteLine(d.name);
            d.Display();
            d.GetName();

        }
    }
}
