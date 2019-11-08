// List 
using System;
using System.Collections.Generic;

public class ListProgram
{
    public static void Main(string[] args)
    {
        // Create a list of strings using collection initializer
        var names = new List<string>
            () { "Andersson", "John", "Daniel", "Carlsson"};
            
        // iterate through the list.
            
        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}