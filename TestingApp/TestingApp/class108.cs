// Stack<T>

using System;
using System.Collections.Generic;

public class StackProgram
{
    public static void Main(string[] args)
    {
        Stack<string> names = new Stack<string>();
        names.Push("Andersson");
        names.Push("Petersson");
        names.Push("Jane");
        names.Push("Ricky");
        names.Push("Donald");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Peek element: " + names.Peek());
        Console.WriteLine("Pop: " + names.Pop());
        Console.WriteLine("After Pop, Peek element: " + names.Peek());

    }
}