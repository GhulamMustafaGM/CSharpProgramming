using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "hey";

        char[] ch = { 'W', 'o', 'r', 'd', '!' };
        string s2 = new string(ch);

        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}