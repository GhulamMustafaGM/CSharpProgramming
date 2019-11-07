// String IsInterned() method

using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello hello C#";
        string s3 = string.Intern(s1);
        string s4 = string.IsInterned(s1);

        Console.WriteLine(s1);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
    }
}