// String LastIndexOf()

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s3 = "Hello C#";
        int index = s3.LastIndexOf('l');

        Console.WriteLine(index);
    }
}