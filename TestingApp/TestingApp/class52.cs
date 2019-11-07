using System;
public class Stringprogram
{
    public static void Main(string[] args)
    {
        string s1 = "hej";
        string s2 = "hej";
        string s3 = "World!";

        Console.WriteLine(s1.CompareTo(s2));
        Console.WriteLine(s2.CompareTo(s3));
    }
}