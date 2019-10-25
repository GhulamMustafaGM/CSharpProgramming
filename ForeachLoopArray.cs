/* we can declare three ways to initialize array at the same time. 
 * 
 *int[] arr = new int[3] {20,30,40,50};
 * 
 * 
 * int[] arr = new int[] {40, 20, 50, 10};   // omit the size of array 
 * 
 * int[] arr = {10,30,50,20,60}; // omit the new oerator 
 * 
 */

// Defined traversal using foreach loop

using System;

public class ForeachLoopArray


{
    public static void Main(string[] args)
    {
        int[] arr = { 20, 30, 40, 50, 60 }; // declaring and initialzing array

        foreach(int a in arr)
        {
            Console.WriteLine(a);
        }
    }
}

/*
 * output
 * 
 * 20
 * 30
 * 40
 * 50
 * 60
 */