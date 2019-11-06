using System;
public class Counting
{
    public static int add(int i, int j)
    {
        return i + j;
    }
    public static int add(int i, int j, int k)
    {
        return i + j + k;
    }
}
public class TestMemberOverloading
{
    public static void Main()
    {
        Console.WriteLine(Counting.add(13, 13));
        Console.WriteLine(Counting.add(10, 23, 25));
    }
}