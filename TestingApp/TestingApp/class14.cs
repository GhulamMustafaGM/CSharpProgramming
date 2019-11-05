// Finding Area 

using System;
public struct RectangleShape
{
    public int width, height;

}
public class TestStructs
{
    public static void Main()
    {
        RectangleShape r = new RectangleShape();
        r.width = 4;
        r.height = 5;
        Console.WriteLine("Area of Rectangle is: " + (r.width * r.height));
    }
}