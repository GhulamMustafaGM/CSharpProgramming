// String ToLowerInvariant() Method

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";
        string s2 = s1.ToLowerInvariant();

        Console.WriteLine(s2);
    }
}