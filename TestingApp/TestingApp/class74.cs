// String IndexOf() vs LastIndexOf()

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s3 = "Hello C#";

        int first = s3.IndexOf('l');
        int last = s3.LastIndexOf('l');

        Console.WriteLine(first);
        Console.WriteLine(last);
    }
}