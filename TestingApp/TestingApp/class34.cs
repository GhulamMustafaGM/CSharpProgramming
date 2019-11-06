using System;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("eating...");
    }
}
public class Cat : Animal
{
    public override void eat()
    {
        Console.WriteLine("eating bread...");
    }

}
public class TestingPolymorphism
{
    public static void Main()
    {
        Animal a = new Cat();
        a.eat();
    }
}