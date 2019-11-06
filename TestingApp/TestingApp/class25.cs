using System;
public class Animal
{
    public void eat() { Console.WriteLine("Eating..."); }
}
public class Cat : Animal
{
    public void Mew() { Console.WriteLine("Mew mew mew..."); }
}
class TestInheritance2
{
    public static void Main(string[] args)
    {
        Cat c1 = new Cat();
        c1.eat();
        c1.Mew();
    }
}