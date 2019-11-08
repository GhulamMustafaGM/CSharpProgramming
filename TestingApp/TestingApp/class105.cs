// HashSetProgram

using System;
using System.Collections.Generic;

public class ListSetProgram
{
    public static void Main(string[] args)
    {
        // Create a set of strings  
        var names = new HashSet<string>();

        names.Add("John");
        names.Add("Andersson");
        names.Add("Karlssson");
        names.Add("Daniel");
        names.Add("Lara");  //will not be added  

        // Iterate HashSet elements using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}