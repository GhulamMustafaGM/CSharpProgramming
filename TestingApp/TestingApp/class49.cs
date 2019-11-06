using System;

public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hej ";
        string s2 = (String)s1.Clone();
        string s3 = (String)s1.Clone();
        string s4 = (String)s1.Clone();

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
    }
}