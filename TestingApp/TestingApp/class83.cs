// String Split() Method 

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C Sharp";
        string[] s2 = s1.Split(' ');

        foreach (string s5 in s2)
        {
            Console.WriteLine(s5);
        }
    }
}