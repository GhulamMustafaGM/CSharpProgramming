// String Normalize() method

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";
        bool b1 = s1.IsNormalized();
        Console.WriteLine(s1);
        Console.WriteLine(b1);
    }
}