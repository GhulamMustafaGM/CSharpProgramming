// String PadRight() Method 

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";// 8 length of characters  
        string s2 = s1.PadRight(15);
        Console.Write(s2);//padding at right side (15-8=7)  
        Console.Write("JavaScript ");//will be written after 7 white spaces  
    }
}