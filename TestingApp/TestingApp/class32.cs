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
        base.eat();
        Console.WriteLine("eating bread...");
    }

}
public class TestBase
{
    public static void Main()
    {
        Cat c = new Cat();
        c.eat();
    }
}