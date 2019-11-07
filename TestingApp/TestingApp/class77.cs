// String PadLeft() Method 

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";// 8 length of characters  
        string s2 = s1.PadLeft(10);//(10-8=2) adds 2 whitespaces at the left side  

        Console.WriteLine(s2);
    }
}