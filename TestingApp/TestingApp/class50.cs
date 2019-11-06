using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hi";
        string s2 = "Hi";
        string s3 = "World!";
        string s4 = "Dear!";

        Console.WriteLine(string.Compare(s1, s2));
        Console.WriteLine(string.Compare(s2, s3));
        Console.WriteLine(string.Compare(s3, s4));
    }
}