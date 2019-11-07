// String Copy() Method 

using System;

public class StringProgram

{
    public static void Main(string[] args)
    {
        string S1 = "Hej ";
        string S2 = string.Copy(S1);

        Console.WriteLine(S1);
        Console.WriteLine(S2);

    }
}