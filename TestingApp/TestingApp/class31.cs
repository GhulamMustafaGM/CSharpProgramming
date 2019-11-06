using System;
public class Animal
{
    public string color = "white";
}
public class Cat : Animal
{
    string color = "black";
    public void showColor()
    {
        Console.WriteLine(base.color);
        Console.WriteLine(color);
    }

}
public class TestBase
{
    public static void Main()
    {
        Cat c = new Cat();
        c.showColor();
    }
}