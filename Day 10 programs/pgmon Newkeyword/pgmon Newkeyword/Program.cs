using System;
public class Animal
{
    public void WildAnimals()
    {
        Console.WriteLine("LION");
    }
}

public class Cat : Animal 
{
    public new void WildAnimals()
    {
        Console.WriteLine("Dog");
    }
}
public class NewProgram
{
    public static void Main(string[] args)
    {
        Animal a = new Animal();
        a.WildAnimals();

        Cat c = new Cat();
        c.WildAnimals();
    }
}
