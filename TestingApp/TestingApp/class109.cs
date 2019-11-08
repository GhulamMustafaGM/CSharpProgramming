// Queue<T>

using System;
using System.Collections.Generic;

public class QueueProgram
{
    public static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>();
        names.Enqueue("Andersson");
        names.Enqueue("Petersson");
        names.Enqueue("Tony");
        names.Enqueue("Pointing");
        names.Enqueue("David");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Peek element: " + names.Peek());
        Console.WriteLine("Dequeue: " + names.Dequeue());
        Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
    }
}