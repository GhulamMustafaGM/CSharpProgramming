using System;
public class MainShape
{
    public virtual void draw()
    {
        Console.WriteLine("drawing...");
    }
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
    }

}
public class TestingPolymorphism
{
    public static void Main()
    {
        MainShape ms;
        ms = new MainShape();
        ms.draw();
        ms = new Rectangle();
        ms.draw();
        ms = new Circle();
        ms.draw();

    }
}