// String Intern() vs IsInterned() method

using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string x = new string(new[] { 'x' });
        string y = new string(new[] { 'y' });

        string.Intern(x); // interns it
        Console.WriteLine(string.IsInterned(x) != null); // true

        string.IsInterned(y); // doesn't intern it

        Console.WriteLine(string.IsInterned(y) != null); // false
    }
}