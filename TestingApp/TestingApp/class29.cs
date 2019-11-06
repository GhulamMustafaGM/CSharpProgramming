using System;
public class Counting
{
    public static int add(int x, int y)
    {
        return x + y;
    }
    public static float add(float x, float y)
    {
        return x + y;
    }
}
public class TestMemberOverloading
{
    public static void Main()
    {
        Console.WriteLine(Counting.add(10, 22));
        Console.WriteLine(Counting.add(11.4f, 20.3f));
    }
}