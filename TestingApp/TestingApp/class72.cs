// String Join()

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string[] s1 = { "Hello", "C#", "by", "javatpoint" };
        string s3 = string.Join("-", s1);

        Console.WriteLine(s3);
    }
}