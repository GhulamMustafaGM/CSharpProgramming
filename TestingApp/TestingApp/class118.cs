// Reflection Program

using System;
using System.Reflection;
public class ReflectionProgram
{
    public static void Main()
    {
        Type t = typeof(System.String);
        Console.WriteLine(t.Assembly);
    }
}