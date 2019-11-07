// String StartsWith()

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C Sharp";
        bool b1 = s1.StartsWith("h");
        bool b2 = s1.StartsWith("H");

        Console.WriteLine(b1);
        Console.WriteLine(b2);
    }
}