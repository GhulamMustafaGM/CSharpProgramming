// String Format()

using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
       string s1 = string.Format("{0:D}", DateTime.Now);

        Console.WriteLine(s1);
    }
}