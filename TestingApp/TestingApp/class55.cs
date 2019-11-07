// String CopyTo() Method

using System;
public class StringExample
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#, How are You?";
        char[] ch = new char[15];

        s1.CopyTo(10, ch, 0, 12);
        Console.WriteLine(ch);
    }
}