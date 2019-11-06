using System;
public interface MainDrawable
{
    void draw();
}
public class Rectangle : MainDrawable
{
    public void draw()
    {
        Console.WriteLine("drawing rectangle...");
    }
}
public class Circle : MainDrawable
{
    public void draw()
    {
        Console.WriteLine("drawing circle...");
        Console.WriteLine("\n");
    }
}
public class TestingInterface
{
    public static void Main()
    {
        MainDrawable md;
        md = new Rectangle();
        md.draw();
        md = new Circle();
        md.draw();
    }
}