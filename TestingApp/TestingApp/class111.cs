// LinkedList 
using System;
using System.Collections.Generic;

public class LinkedListProgram
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        var names = new LinkedList<string>();
        names.AddLast("James");
        names.AddLast("Anderson");
        names.AddLast("Petersson");
        names.AddLast("John");

        //insert new element before "Peter"  
        LinkedListNode<String> node = names.Find("Petersson");
        names.AddBefore(node, "James");
        names.AddAfter(node, "Petersson");

        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}