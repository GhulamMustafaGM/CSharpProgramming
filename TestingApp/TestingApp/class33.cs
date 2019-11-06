using System;
public class Animal
{
    public Animal()
    {
        Console.WriteLine("animal...");
    }
}
public class Cat : Animal
{
    public Cat()
    {
        Console.WriteLine("cat...");
    }

}
public class TestingOverriding
{
    public static void Main()
    {
        Cat c = new Cat();

    }
}