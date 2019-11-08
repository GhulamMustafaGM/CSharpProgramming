// Reflection Program

using System;
public class ReflectionProgram
{
    public static void Main()
    {
        int a = 10;
        Type type = a.GetType();
        Console.WriteLine(type);
    }
}