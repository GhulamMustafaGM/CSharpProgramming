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

// Defined Passing Array to Function 

using System;

public class PassingArrayFunc
{
    static void printArray(int[] arr)
    {
        Console.WriteLine("Printing array values:");

        for (int a = 0; a < arr.Length; a++)
        {
            Console.WriteLine(arr[a]);
        }
    }
    public static void Main(string[] args)
    {
        int[] arr1 = { 22, 15, 40, 25, 60, 80 };
        int[] arr2 = { 11, 26, 34, 51, 74 };

        printArray(arr1);   //passing array values to function  

        printArray(arr2);
    }
}