// LinkedList 
using System;
using System.Collections.Generic;

public class LinkedListProgram
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        var names = new LinkedList<string>();
        names.AddLast("Moses");
        names.AddLast("Aderas");
        names.AddLast("Petersson");
        names.AddLast("John Duck");
        names.AddFirst("Jane Doe");//added to first index  

        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}