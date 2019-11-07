// String Insert() method

using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello hello C#";
        string s3 = s1.Insert(5, "-");

        Console.WriteLine(s3);
    }
}