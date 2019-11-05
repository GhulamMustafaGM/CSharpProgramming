// Static field => Using Constructor and Method

using System;
public struct RectangleShape
{
    public int width, height;

    public RectangleShape(int w, int h)
    {
        width = w;
        height = h;
    }
    public void areaOfRectangle()
    {
        Console.WriteLine("Area of Rectangle is: " + (width * height));
    }
}
public class TestStructs
{
    public static void Main()
    {
        RectangleShape r = new RectangleShape(6, 7);
        r.areaOfRectangle();
    }
}