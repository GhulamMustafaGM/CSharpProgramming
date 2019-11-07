// String SubString()

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C Sharp";
        string s2 = s1.Substring(5);

        Console.WriteLine(s2);
    }
}