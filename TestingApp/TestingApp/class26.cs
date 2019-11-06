using System;
public class Animal
{
    public void eat() { Console.WriteLine("Eating..."); }
}
public class Cat : Animal
{
    public void Mew() { Console.WriteLine("Mew mow mow..."); }
}
public class BabyCat : Cat
{
    public void weep() { Console.WriteLine("Weeping..."); }
}
class TestInheritance2
{
    public static void Main(string[] args)
    {
        BabyCat c1 = new BabyCat();
        c1.eat();
        c1.Mew();
        c1.weep();
    }
}