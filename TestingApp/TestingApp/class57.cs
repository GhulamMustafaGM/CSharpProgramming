// String Equals()
using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = "Hello";
        string s3 = "Bye";

        Console.WriteLine(s1.Equals(s2));
        Console.WriteLine(s1.Equals(s3));
    }
}