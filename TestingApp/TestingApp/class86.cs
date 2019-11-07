// String ToCharArray()

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";
        char[] ch = s1.ToCharArray();
        foreach (char c in ch)
        {
            Console.WriteLine(c);
        }
    }
}