// String Replace() Method 

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#, Hello .Net, Hello JavaScript";
        string s2 = s1.Replace("Hello", "Cheers");
        Console.WriteLine(s2);
    }
}