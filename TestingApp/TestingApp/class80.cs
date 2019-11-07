// String Remove() Method 

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s2 = "abcdefghijklmn";
        string s3 = s2.Remove(5,6);

        Console.WriteLine(s3);
    }
}