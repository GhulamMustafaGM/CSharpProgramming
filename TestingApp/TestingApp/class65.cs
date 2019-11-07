// String Intern(String str) method

using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello hello C#";
        string s3 = string.Intern(s1);

        Console.WriteLine(s1);
        Console.WriteLine(s3);
    }
}