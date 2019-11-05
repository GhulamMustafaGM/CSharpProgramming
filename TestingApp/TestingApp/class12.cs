using System;
public static class MyCalculation
{
    public static float PI = 3.14f;
    public static int cube(int n) { return n * n * n; }
}
class TestCalculation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Value of PI is: " + MyCalculation.PI);
        Console.WriteLine("Cube of 3 is: " + MyCalculation.cube(3));
    }
}