using System;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("Eating...");
    }
}
public class Cat : Animal
{
    public override void eat()
    {
        Console.WriteLine("Eating bread...");
    }
}
public class TestOverriding
{
    public static void Main()
    {
        Cat c = new Cat();
        c.eat();
    }
}