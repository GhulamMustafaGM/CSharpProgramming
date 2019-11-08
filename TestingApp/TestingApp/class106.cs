// SortedSet <T>

using System;
using System.Collections.Generic;

public class ListSetProgram
{
    public static void Main(string[] args)
    {
        // Create a set of strings  
        var names = new SortedSet<string>();

        names.Add("Roland");
        names.Add("Andersson");
        names.Add("Petersson");
        names.Add("Ricky");
        names.Add("Bush");  //will not be added  

        // Iterate SortedSet elements using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}