// BreakProgram 

using System;
public class BreakExample
{
    public static void Main(string[] args)
    {
        for (int a = 1; a <= 15; a++)
        {
            if (a == 5)
            {
                break;
            }
            Console.WriteLine(a);
        }
    }
}