// List 
using System;
using System.Collections.Generic;

public class ListProgram
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        var names = new List<string>();

        names.Add("Donald Duck");
        names.Add("John Doe");
        names.Add("Jane Doe");
        names.Add("Anderson");

        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}