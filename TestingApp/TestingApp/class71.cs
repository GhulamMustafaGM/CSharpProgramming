// String IsNullOrWhiteSpace()

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";
        string s2 = "";
        string s3 = " ";

        bool b1 = string.IsNullOrWhiteSpace(s1);
        bool b2 = string.IsNullOrWhiteSpace(s2);
        bool b3 = string.IsNullOrWhiteSpace(s3);

        Console.WriteLine(b1);       // returns False   
        Console.WriteLine(b2);       // returns True   
        Console.WriteLine(b3);       // returns True   
    }
}