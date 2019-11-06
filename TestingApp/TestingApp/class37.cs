
// Abstract class 

using System;
public abstract class MainShape
{
    public abstract void draw();
}
public class Rectangle : MainShape
{
    public override void draw()
    {
        Console.WriteLine("drawing rectangle...");
    }
}
public class Circle : MainShape
{
    public override void draw()
    {
        Console.WriteLine("drawing circle...");
        Console.WriteLine("\n");
    }
}
public class TestingAbstract
{
    public static void Main()
    {
        MainShape ms;
        ms = new Rectangle();
        ms.draw();
        ms = new Circle();
        ms.draw();
    }
}