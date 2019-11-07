// String TrimEnd() Method

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";
        char[] ch = { '#' };
        string s3 = s1.Trim(ch);

        Console.WriteLine(s3);
    }
}