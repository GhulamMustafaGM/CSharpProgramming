// C# String contains()

using System;

public class StringProgram

{
    public static void Main(string[] args)
    {
        string S1 = "Hej ";
        string S2 = "World!";
        string S3 = "Hi";

        Console.WriteLine(S1.Contains(S2));
        Console.WriteLine(S1.Contains(S3));

    }
}